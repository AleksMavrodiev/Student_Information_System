using Microsoft.EntityFrameworkCore;
using StudentInformationSystem.Data;
using StudentInformationSystem.Services.Contracts;
using StudentInformationSystem.Web.ViewModels.University;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInformationSystem.Data.Models;

namespace StudentInformationSystem.Services.Services
{
    public class UniversityService : Contracts.IUniversityService
    {
        private readonly StudentInformationDbContext dbContext;

        public UniversityService(StudentInformationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IEnumerable<UniversityAllViewModel>> ShowAll()
        {
            IEnumerable<UniversityAllViewModel> universities = await this.dbContext.Universities.Select(u => new UniversityAllViewModel
            {
                Id = u.Id,
                Name = u.Name,
                Adress = u.Address
            }).ToArrayAsync();

            return universities;
        }

        public async Task Create(UniversityCreateViewModel universityCreateViewModel)
        {
            var university = new University
            {
                Name = universityCreateViewModel.Name,
                Address = universityCreateViewModel.Address,
                PostCode = universityCreateViewModel.PostCode
            };

            await this.dbContext.Universities.AddAsync(university);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<University> GetUniversityById(int id)
        {
            return await this.dbContext.Universities.FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<UniversityEditViewModel> GetUniversityEditViewModelById(int id)
        {
            var university = await this.GetUniversityById(id);
            var universityForEdit = new UniversityEditViewModel
            {
                Id = university.Id,
                Name = university.Name,
                Address = university.Address,
                PostCode = university.PostCode
            };

            return universityForEdit;
        }

        public async Task Edit(int id, UniversityEditViewModel universityEditViewModel)
        {
            var university = await this.GetUniversityById(id);
            university.Name = universityEditViewModel.Name;
            university.Address = universityEditViewModel.Address;
            university.PostCode = universityEditViewModel.PostCode;
            await this.dbContext.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var university = await this.GetUniversityById(id);
            this.dbContext.Universities.Remove(university);
            await this.dbContext.SaveChangesAsync();
        }
    }
}
