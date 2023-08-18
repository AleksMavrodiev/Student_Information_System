using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentInformationSystem.Data;
using StudentInformationSystem.Data.Models;
using StudentInformationSystem.Services.Contracts;
using StudentInformationSystem.Web.ViewModels.Course;
using StudentInformationSystem.Web.ViewModels.Teacher;

namespace StudentInformationSystem.Services.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly StudentInformationDbContext dbContext;

        public TeacherService(StudentInformationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IEnumerable<TeacherListViewModel>> GetTeachersForListItemAsync()
        {
            var teachers = await this.dbContext.Teachers.Select(t => new TeacherListViewModel()
            {
                Id = t.Id.ToString(),
                FullName = t.FirstName + " " + t.LastName,
            }).ToArrayAsync();

            

            return teachers;
        }

        public async Task AddTeacherAsync(TeacherAddViewModel model)
        {
            var passwordHasher = new PasswordHasher<IdentityUser>();
            string initialPassword = "123456";

            var teacher = new Teacher()
            {
                Id = Guid.NewGuid(),
                FirstName = model.FirstName,
                LastName = model.LastName,
                EGN = model.EGN,
                Email = model.Email,
                PhoneNumber = model.PhoneNumber,
            };

            teacher.User = new IdentityUser()
            {
                UserName = model.Email,
                Email = model.Email,
                Id = teacher.Id.ToString(),
                NormalizedUserName = model.Email.ToUpper()
            };

            teacher.User.PasswordHash = passwordHasher.HashPassword(teacher.User, initialPassword);
            await this.dbContext.Teachers.AddAsync(teacher);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<TeacherAllViewModel>> GetAllTeachersAsync()
        {
            return await this.dbContext.Teachers.Select(t => new TeacherAllViewModel()
            {
                Id = t.Id.ToString(),
                FirstName = t.FirstName,
                LastName = t.LastName,
                PhoneNumber = t.PhoneNumber
            }).ToArrayAsync();
        }

        public async Task<IEnumerable<TeacherCoursesViewModel>> GetTeacherCoursesAsync(string teacherId)
        {
            return await this.dbContext.Courses.Where(c => c.TeacherId.ToString() == teacherId).Select(c => new TeacherCoursesViewModel()
            {
                Id = c.Id,
                Name = c.Name,
            }).ToArrayAsync();
        }

        public async Task<TeacherEditViewModel> GetTeacherForEditAsync(string teacherId)
        {
            var teacher = await this.dbContext.Teachers.FirstOrDefaultAsync(t => t.Id.ToString() == teacherId);

            var teacherForEdit = new TeacherEditViewModel()
            {
                Id = teacher.Id.ToString(),
                FirstName = teacher.FirstName,
                LastName = teacher.LastName,
                EGN = teacher.EGN,
                Email = teacher.Email,
                PhoneNumber = teacher.PhoneNumber
            };

            return teacherForEdit;
        }

        public async Task EditTeacherAsync(string id, TeacherEditViewModel model)
        {
            var teacher = this.dbContext.Teachers.FirstOrDefault(t => t.Id.ToString() == id);

            teacher.FirstName = model.FirstName;
            teacher.LastName = model.LastName;
            teacher.EGN = model.EGN;
            teacher.Email = model.Email;
            teacher.PhoneNumber = model.PhoneNumber;

            this.dbContext.Teachers.Update(teacher); 
            await this.dbContext.SaveChangesAsync();
        }

        public async Task DeleteTeacherAsync(string id)
        {
            var teacher = this.dbContext.Teachers.FirstOrDefault(t => t.Id.ToString() == id);
            this.dbContext.Teachers.Remove(teacher);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
