using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentInformationSystem.Data;
using StudentInformationSystem.Data.Models;
using StudentInformationSystem.Services.Contracts;
using StudentInformationSystem.Web.ViewModels.Speacialty;

namespace StudentInformationSystem.Services.Services
{
    public class SpecialtyService : ISpecialtyService
    {
        private readonly StudentInformationDbContext dbContext;

        public SpecialtyService(StudentInformationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }


        public async Task<IEnumerable<SpecialtyListViewModel>> GetSpecialtiesForListItemAsync()
        {
            var specialties = await this.dbContext.Specialties.Select(s => new SpecialtyListViewModel()
            {
                Name = s.Name,
                Id = s.Id
            }).ToArrayAsync();
            
            return specialties;
        }

        public async Task<SpecialtyDetailsViewModel> GetSpecialtyDetailsAsync(int specialtyId)
        {
            var specialty = await this.dbContext.Specialties.FirstOrDefaultAsync(s => s.Id == specialtyId);
            var students = await this.dbContext.Students.Where(s => s.SpecialtyId == specialtyId).ToArrayAsync();
            var courses = await this.dbContext.Courses.Where(c => c.SpecialtyId == specialtyId).ToArrayAsync();

            var specialtyDetails = new SpecialtyDetailsViewModel()
            {
                Id = specialty.Id,
                Name = specialty.Name,
                CourseCount = specialty.Courses.Count,
                StudentCount = specialty.Students.Count,
                Courses = courses,
                Students = students
            };

            return specialtyDetails;
        }

        public async Task AddSpecialtyAsync(SpecialtyAddViewModel model)
        {
            
            var specialty = new Specialty()
            {
                Name = model.Name,
                FacultyId = model.FacultyId,
            };

            var students = await this.dbContext.Students.Where(s => s.SpecialtyId == specialty.Id).ToArrayAsync();
            var courses = await this.dbContext.Courses.Where(c => c.SpecialtyId == specialty.Id).ToArrayAsync();
            await this.dbContext.AddAsync(specialty);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<SpecialtyEditViewModel> GetSpecialtyForEditAsync(int specialtyId)
        {
            var specialty = await this.dbContext.Specialties.FirstOrDefaultAsync(s => s.Id == specialtyId);

            var specialtyEdit = new SpecialtyEditViewModel()
            {
                Id = specialty.Id,
                Name = specialty.Name,
                FacultyId = specialty.FacultyId
            };

            return specialtyEdit;
        }

        public async Task EditSpecialtyAsync(int id, SpecialtyEditViewModel model)
        {
            var specialty = await this.dbContext.Specialties.FirstOrDefaultAsync(s => s.Id == id);
            specialty.Name = model.Name;
            specialty.FacultyId = model.FacultyId;

            await this.dbContext.SaveChangesAsync();
        }

        public async Task DeleteSpecialtyAsync(int specialtyId)
        {
            var specialty = await this.dbContext.Specialties.FirstOrDefaultAsync(s => s.Id == specialtyId);
            this.dbContext.Specialties.Remove(specialty);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task RemoveStudentFromSpecialtyAsync(string studentId)
        {
            var student = await this.dbContext.Students.FirstOrDefaultAsync(s => s.Id.ToString() == studentId);

            student.SpecialtyId = null;
        }

        public async Task<bool> ExistsAsync(int specialtyId)
        {
            return await this.dbContext.Specialties.AnyAsync(s => s.Id == specialtyId);
        }

        public async Task AddStudentToSpecialtyAsync(string studentId, int specialtyId)
        {
            var student = await this.dbContext.Students.FirstOrDefaultAsync(s => s.Id.ToString() == studentId);
            var specialty = await this.dbContext.Specialties.FirstOrDefaultAsync(s => s.Id == specialtyId);

            student.SpecialtyId = specialty.Id;
            student.Specialty = specialty;
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<SpecialtyAllViewModel>> GetSpecialtiesForFacultyAsync(int facultyId)
        {
            return await this.dbContext.Specialties.Where(s => s.FacultyId == facultyId).Select(s => new SpecialtyAllViewModel()
            {
                Id = s.Id,
                Name = s.Name
            }).ToArrayAsync();
        }
    }
}
