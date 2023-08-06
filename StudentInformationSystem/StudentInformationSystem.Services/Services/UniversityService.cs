using Microsoft.EntityFrameworkCore;
using StudentInformationSystem.Data;
using StudentInformationSystem.Services.Contracts;
using StudentInformationSystem.Web.ViewModels.University;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
