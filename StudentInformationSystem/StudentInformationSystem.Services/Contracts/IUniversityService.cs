using StudentInformationSystem.Web.ViewModels.University;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInformationSystem.Data.Models;

namespace StudentInformationSystem.Services.Contracts
{
    public interface IUniversityService
    {
        public Task<IEnumerable<UniversityAllViewModel>> ShowAll();
        public Task Create(UniversityCreateViewModel universityCreateViewModel);
        public Task<University> GetUniversityById(int id);
        public Task<UniversityEditViewModel> GetUniversityEditViewModelById(int id);
        public Task Edit(int id, UniversityEditViewModel universityEditViewModel);
        public Task Delete(int id);
        public Task<IEnumerable<UniversityListViewModel>> GetUniversitiesForDropDownAsync();
    }
}
