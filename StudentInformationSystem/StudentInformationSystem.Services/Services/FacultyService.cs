using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentInformationSystem.Data;
using StudentInformationSystem.Data.Models;
using StudentInformationSystem.Services.Contracts;
using StudentInformationSystem.Web.ViewModels.Faculty;

namespace StudentInformationSystem.Services.Services
{
    public class FacultyService : IFacultyService
    {
        private readonly StudentInformationDbContext dbContext;
        private readonly IUniversityService universityService;

        public FacultyService(StudentInformationDbContext dbContext, IUniversityService universityService)
        {
            this.dbContext = dbContext;
            this.universityService = universityService;
        }
        public async Task<IList<ShowAllFacultiesViewModel>> ShowAllFacultiesForUniversity(int universityId)
        {
            return await this.dbContext.Faculties.Where(f => f.UniversityId == universityId)
                .Select(f => new ShowAllFacultiesViewModel
                {
                    Id = f.Id,
                    Name = f.Name,
                    ImageUrl = f.ImageUrl,
                    Description = f.Description
                })
                .ToArrayAsync();
        }


        public async Task AddFaculty(AddFacultyViewModel model)
        {
            var faculty = new Faculty()
            {
                Name = model.Name,
                ImageUrl = model.ImageUrl,
                Description = model.Description,
                UniversityId = model.UniversityId
            };

            await this.dbContext.Faculties.AddAsync(faculty);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<EditFacultyViewModel> PrepareForEditFaculty(int id)
        {
            var faculty = await this.dbContext.Faculties.FirstOrDefaultAsync(f => f.Id == id);
            var universities = await this.universityService.GetUniversitiesForDropDownAsync();
            var facultyViewModel = new EditFacultyViewModel()
            {
                Id = faculty.Id,
                Name = faculty.Name,
                ImageUrl = faculty.ImageUrl,
                Description = faculty.Description,
                UniversityId = faculty.UniversityId,
                Universities = universities
            };

            return facultyViewModel;
        }

        public async Task EditFaculty(int id, EditFacultyViewModel model)
        {
            var faculty = await this.dbContext.Faculties.FirstOrDefaultAsync(f => f.Id == id);
            faculty.Name = model.Name;
            faculty.ImageUrl = model.ImageUrl;
            faculty.Description = model.Description;
            faculty.UniversityId = model.UniversityId;
            await this.dbContext.SaveChangesAsync();
        }

        public async Task DeleteFaculty(int id)
        {
            var faculty = this.dbContext.Faculties.FirstOrDefault(f => f.Id == id);
            this.dbContext.Faculties.Remove(faculty);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<bool> Exists(int id)
        {
            return await this.dbContext.Faculties.AnyAsync(f => f.Id == id);
        }

        public async Task<IEnumerable<FacultyListViewModel>> FacultiesForDropDown()
        {
            return await this.dbContext.Faculties.Select(f => new FacultyListViewModel()
            {
                Id = f.Id,
                Name = f.Name
            }).ToArrayAsync();
        }
    }
}
