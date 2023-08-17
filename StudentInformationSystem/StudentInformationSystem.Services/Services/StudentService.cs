using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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

        public async Task<Student> GetStudentAsync(string id)
        {
            return await this.dbcontext.Students.FirstOrDefaultAsync(s => s.UserId == id);
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
                Email = $"{student.FirstName.ToLower()}.{student.LastName.ToLower()}@university.com",
                NormalizedUserName = model.Email.ToUpper(),
            };

            student.User.PasswordHash = passwordHasher.HashPassword(student.User, initialPassword);

            await this.dbcontext.Students.AddAsync(student);
            await this.dbcontext.SaveChangesAsync();
        }

        public async Task RemoveStudentProfilePictureAsync(string userId)
        {
            var student = await this.GetStudentAsync(userId);

            student.ProfilePicture = null;

            await dbcontext.SaveChangesAsync();
        }

        public async Task SaveStudentProfilePictureAsync(string userId, IFormFile profilePicture)
        {
            var student = await this.GetStudentAsync(userId);

            using (var memoryStream = new MemoryStream())
            {
                await profilePicture.CopyToAsync(memoryStream);
                student.ProfilePicture = memoryStream.ToArray();
            }

            await this.dbcontext.SaveChangesAsync();
        }

        public async Task<StudentProfileViewModel> GetStudentProfileAsync(string userId)
        {
            var student = await this.GetStudentAsync(userId);

            if (student == null)
            {
                throw new InvalidOperationException("Student not found!");
            }

            return new StudentProfileViewModel()
            {
                FirstName = student.FirstName,
                LastName = student.LastName,
                FacultyNumber = student.FacultyNumber,
                PhoneNumber = student.PhoneNumber,
                Email = student.Email,
                EGN = student.EGN,
                ProfilePicture = student.ProfilePicture
            };
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
