using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentInformationSystem.Data;
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


        public async Task<List<SelectListItem>> GetSpecialtiesForListItemAsync()
        {
            var specialties = await this.dbContext.Specialties.Select(s => new SpecialtyListViewModel()
            {
                Name = s.Name,
                Id = s.Id.ToString()
            }).ToListAsync();
            
            var speacialtiesForListItem = specialties.Select(s => new SelectListItem()
            {
                Text = s.Name,
                Value = s.Id
            }).ToList();

            return speacialtiesForListItem;
        }
    }
}
