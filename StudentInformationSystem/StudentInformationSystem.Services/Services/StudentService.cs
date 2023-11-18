using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Castle.Core.Internal;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StudentInformationSystem.Data;
using StudentInformationSystem.Data.Models;
using StudentInformationSystem.Services.Contracts;
using StudentInformationSystem.Web.ViewModels.Student;
using StudentInfromationSystem.Data.Models;

namespace StudentInformationSystem.Services.Services
{
    public class StudentService : IStudentService
    {
        private readonly StudentInformationDbContext dbcontext;
        private readonly IUserService userService;
        private readonly ISpecialtyService specialtyService;
        private readonly IEmailService emailService;

        public StudentService(StudentInformationDbContext dbContext, IUserService userService, ISpecialtyService specialtyService, IEmailService emailService)
        {
            this.dbcontext = dbContext;
            this.userService = userService;
            this.specialtyService = specialtyService;
            this.emailService = emailService;
        }


        public async Task<IEnumerable<StudentAllViewModel>> GetStudentsAsync(string search)
        {
            var students = this.dbcontext.Students.AsQueryable();
            if (!search.IsNullOrEmpty())
            {
                students = students.Where(x => x.User.FirstName.Contains(search) || x.User.LastName.Contains(search));
            }

            var viewModel = await students.Select(x => new StudentAllViewModel
            {
                Id = x.Id.ToString(),
                FirstName = x.User.FirstName,
                LastName = x.User.LastName,
                FacultyNumber = x.FacultyNumber,
            }).ToArrayAsync();

            return viewModel;
        }

        public async Task<Student> GetStudentAsync(string id)
        {
            return await this.dbcontext.Students.FirstOrDefaultAsync(s => s.UserId == id);
        }

        public async Task CreateStudentAsync(StudentAddViewModel model)
        {
            var passwordHasher = new PasswordHasher<ApplicationUser>();
            string initialPassword = "123456";

            var student = new Student
            {
                Id = Guid.NewGuid(),
                FacultyNumber = model.FacultyNumber,
                IsActive = model.IsActive,
                IsForeign = model.IsForeign,
                SpecialtyId = model.SpecialtyId,
            };


            student.User = new ApplicationUser()
            {
                Id = student.Id.ToString(),
                UserName = model.Email,
                Email = model.Email,
                NormalizedUserName = model.Email.ToUpper(),
                FirstName = model.FirstName,
                LastName = model.LastName,
                EGN = model.EGN,
                PhoneNumber = model.PhoneNumber,
                ProfilePicture = model.ProfilePicture,
                PasswordRequiredChange = true
            };

            student.UserId = student.User.Id;
            student.User.PasswordHash = passwordHasher.HashPassword(student.User, initialPassword);

            await this.dbcontext.Students.AddAsync(student);
            await this.dbcontext.SaveChangesAsync();

            var subject = "Welcome to Our Application";
            var message = $"Hello {student.User.UserName},<br />"
                          + $"Your email: {student.User.Email}<br />"
                          + $"Your initial password: {initialPassword}<br />"
                          + "Please login and change your password.";

            await this.emailService.SendEmailAsync(student.User.Email, subject, message, student.User.UserName);
        }

        public async Task RemoveStudentProfilePictureAsync(string userId)
        {
            var student = await this.GetStudentAsync(userId);

            student.User.ProfilePicture = null;

            await dbcontext.SaveChangesAsync();
        }

        public async Task SaveStudentProfilePictureAsync(string userId, IFormFile profilePicture)
        {
            var student = await this.GetStudentAsync(userId);

            using (var memoryStream = new MemoryStream())
            {
                await profilePicture.CopyToAsync(memoryStream);
                student.User.ProfilePicture = memoryStream.ToArray();
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
                FirstName = student.User.FirstName,
                LastName = student.User.LastName,
                FacultyNumber = student.FacultyNumber,
                PhoneNumber = student.User.PhoneNumber,
                Email = student.User.Email,
                EGN = student.User.EGN,
                ProfilePicture = student.User.ProfilePicture
            };
        }

        public async Task UpdateStudentAsync(string id, StudentEditViewModel student)
        {
            var studentToUpdate = await this.GetStudentAsync(id);
            studentToUpdate.User.FirstName = student.FirstName;
            studentToUpdate.User.LastName = student.LastName;
            studentToUpdate.FacultyNumber = student.FacultyNumber;
            studentToUpdate.User.PhoneNumber = student.PhoneNumber;
            studentToUpdate.User.Email = student.Email;
            studentToUpdate.User.EGN = student.EGN;
            studentToUpdate.IsActive = student.IsActive;
            studentToUpdate.IsForeign = student.IsForeign;
            studentToUpdate.SpecialtyId = student.SpecialtyId;

            await this.dbcontext.SaveChangesAsync();
        }

        public async Task DeleteStudentAsync(string id)
        {
            var student = await this.GetStudentAsync(id);
            this.dbcontext.Remove(student);
            await this.userService.RemoveUserAsync(id);
        }

        public async Task<StudentEditViewModel> GetStudentEditAsync(string id)
        {
            var student = await this.GetStudentAsync(id);
            var specialties = await this.specialtyService.GetSpecialtiesForListItemAsync();

            var studentToEdit = new StudentEditViewModel()
            {
                FirstName = student.User.FirstName,
                LastName = student.User.LastName,
                FacultyNumber = student.FacultyNumber,
                PhoneNumber = student.User.PhoneNumber,
                Email = student.User.Email,
                EGN = student.User.EGN,
                Specialties = specialties
            };

            return studentToEdit;
        }

        public async Task<string> GetStudentIdByEmail(string email)
        {
            var student = await this.dbcontext.Students.FirstOrDefaultAsync(s => s.User.Email == email);

            return student.User.Id.ToString();
        }
    }
}
