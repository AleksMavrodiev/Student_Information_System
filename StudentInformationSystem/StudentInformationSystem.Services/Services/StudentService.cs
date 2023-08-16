using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentInformationSystem.Data;
using StudentInformationSystem.Data.Models;
using StudentInformationSystem.Services.Contracts;
using StudentInformationSystem.Web.ViewModels.Student;

namespace StudentInformationSystem.Services.Services
{
    public class StudentService : IStudentService
    {
        private readonly StudentInformationDbContext dbcontext;

        public StudentService(StudentInformationDbContext dbContext)
        {
            this.dbcontext = dbContext;
        }


        public async Task<IEnumerable<StudentAllViewModel>> GetStudentsAsync()
        {
            return await this.dbcontext.Students.Select(x => new StudentAllViewModel
            {
                Id = x.Id.ToString(),
                FirstName = x.FirstName,
                LastName = x.LastName,
                FacultyNumber = x.FacultyNumber
            }).ToArrayAsync();
        }

        public Task<Student> GetStudentAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task CreateStudentAsync(StudentAddViewModel model)
        {
            var passwordHasher = new PasswordHasher<IdentityUser>();
            string initialPassword = "123456";

            var student = new Student
            {
                Id = Guid.NewGuid(),
                FirstName = model.FirstName,
                LastName = model.LastName,
                EGN = model.EGN,
                Email = model.Email,
                FacultyNumber = model.FacultyNumber,
                PhoneNumber = model.PhoneNumber,
                ProfilePicture = model.ProfilePicture,
                IsActive = model.IsActive,
                IsForeign = model.IsForeign,
                SpecialtyId = model.SpecialtyId
            };

            student.User = new IdentityUser()
            {
                Id = student.Id.ToString(),
                UserName = model.Email,
                Email = $"{student.FirstName.ToLower()}.{student.LastName.ToLower()}",
                NormalizedUserName = model.Email.ToUpper(),
            };

            student.User.PasswordHash = passwordHasher.HashPassword(student.User, initialPassword);
            await this.dbcontext.Students.AddAsync(student);
            await this.dbcontext.SaveChangesAsync();
        }

        public Task<Student> UpdateStudentAsync(Student student)
        {
            throw new NotImplementedException();
        }

        public Task DeleteStudentAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
