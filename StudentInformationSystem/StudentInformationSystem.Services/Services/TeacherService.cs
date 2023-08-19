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
using StudentInfromationSystem.Data.Models;

namespace StudentInformationSystem.Services.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly StudentInformationDbContext dbContext;
        private readonly IUserService userService;
        private readonly IEmailService emailService;

        public TeacherService(StudentInformationDbContext dbContext, IUserService userService, IEmailService emailService)
        {
            this.dbContext = dbContext;
            this.userService = userService;
            this.emailService = emailService;
        }
        public async Task<IEnumerable<TeacherListViewModel>> GetTeachersForListItemAsync()
        {
            var teachers = await this.dbContext.Teachers.Select(t => new TeacherListViewModel()
            {
                Id = t.Id.ToString(),
                FullName = t.User.FirstName + " " + t.User.LastName,
            }).ToArrayAsync();

            

            return teachers;
        }

        public async Task AddTeacherAsync(TeacherAddViewModel model)
        {
            var passwordHasher = new PasswordHasher<ApplicationUser>();
            string initialPassword = "123456";

            var teacher = new Teacher()
            {
                Id = Guid.NewGuid(),
            };

            teacher.User = new ApplicationUser()
            {
                UserName = model.Email,
                Email = model.Email,
                Id = teacher.Id.ToString(),
                NormalizedUserName = model.Email.ToUpper(),
                FirstName = model.FirstName,
                LastName = model.LastName,
                EGN = model.EGN,
                PhoneNumber = model.PhoneNumber,
                PasswordRequiredChange = true
            };

            teacher.User.PasswordHash = passwordHasher.HashPassword(teacher.User, initialPassword);
            await this.dbContext.Teachers.AddAsync(teacher);
            await this.dbContext.SaveChangesAsync();

            var subject = "Welcome to Our Application";
            var message = $"Hello {teacher.User.UserName},<br />"
                          + $"Your email: {teacher.User.Email}<br />"
                          + $"Your initial password: {initialPassword}<br />"
                          + "Please login and change your password.";

            await this.emailService.SendEmailAsync(teacher.User.Email, subject, message, teacher.User.UserName);
        }

        public async Task<IEnumerable<TeacherAllViewModel>> GetAllTeachersAsync()
        {
            return await this.dbContext.Teachers.Select(t => new TeacherAllViewModel()
            {
                Id = t.Id.ToString(),
                FirstName = t.User.FirstName,
                LastName = t.User.LastName,
                PhoneNumber = t.User.PhoneNumber
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
                FirstName = teacher.User.FirstName,
                LastName = teacher.User.LastName,
                EGN = teacher.User.EGN,
                Email = teacher.User.Email,
                PhoneNumber = teacher.User.PhoneNumber
            };

            return teacherForEdit;
        }

        public async Task EditTeacherAsync(string id, TeacherEditViewModel model)
        {
            var teacher = this.dbContext.Teachers.FirstOrDefault(t => t.Id.ToString() == id);

            teacher.User.FirstName = model.FirstName;
            teacher.User.LastName = model.LastName;
            teacher.User.EGN = model.EGN;
            teacher.User.Email = model.Email;
            teacher.User.PhoneNumber = model.PhoneNumber;

            this.dbContext.Teachers.Update(teacher); 
            await this.dbContext.SaveChangesAsync();
        }

        public async Task DeleteTeacherAsync(string id)
        {
            var teacher = this.dbContext.Teachers.FirstOrDefault(t => t.Id.ToString() == id);
            this.dbContext.Teachers.Remove(teacher);
            var courses = this.dbContext.Courses.Where(c => c.TeacherId.ToString() == id);

            foreach (var course in courses)
            {
                course.TeacherId = null;
            }
            await this.dbContext.SaveChangesAsync();
            await this.userService.RemoveUserAsync(id);
        }

        public async Task GradeStudentAsync(string studentId, int courseId, int grade)
        {
            var course =  await this.dbContext.StudentCourses.FirstOrDefaultAsync(sc =>
                sc.StudentId.ToString() == studentId && sc.CourseId == courseId);

            course.Grade = grade;
            await this.dbContext.SaveChangesAsync();
        }
    }
}
