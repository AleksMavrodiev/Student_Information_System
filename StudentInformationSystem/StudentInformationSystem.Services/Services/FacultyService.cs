using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentInformationSystem.Data;
using StudentInformationSystem.Services.Contracts;
using StudentInformationSystem.Web.ViewModels.Faculty;

namespace StudentInformationSystem.Services.Services
{
    public class FacultyService : IFacultyService
    {
        private readonly StudentInformationDbContext dbContext;

        public FacultyService(StudentInformationDbContext dbContext)
        {
            this.dbContext = dbContext;
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
    }
}
