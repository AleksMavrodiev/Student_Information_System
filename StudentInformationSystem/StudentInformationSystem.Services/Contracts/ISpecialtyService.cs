using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentInformationSystem.Web.ViewModels.Speacialty;

namespace StudentInformationSystem.Services.Contracts
{
    public interface ISpecialtyService
    {
        public Task<IEnumerable<SpecialtyListViewModel>> GetSpecialtiesForListItemAsync();

        public Task<SpecialtyDetailsViewModel> GetSpecialtyDetailsAsync(int specialtyId);
        public Task AddSpecialtyAsync(SpecialtyAddViewModel model);
        public Task<SpecialtyEditViewModel> GetSpecialtyForEditAsync(int specialtyId);
        public Task EditSpecialtyAsync(int id, SpecialtyEditViewModel model);
        public Task DeleteSpecialtyAsync(int specialtyId);
        public Task RemoveStudentFromSpecialtyAsync(string studentId);
        public Task<bool> ExistsAsync(int specialtyId);
        public Task AddStudentToSpecialtyAsync(string studentId, int specialtyId);
        public Task<IEnumerable<SpecialtyAllViewModel>> GetSpecialtiesForFacultyAsync(int facultyId);
    }
}
