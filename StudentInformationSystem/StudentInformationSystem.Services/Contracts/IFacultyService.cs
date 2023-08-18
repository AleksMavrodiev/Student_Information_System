using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInformationSystem.Web.ViewModels.Faculty;

namespace StudentInformationSystem.Services.Contracts
{
    public interface IFacultyService
    {
        Task<IList<ShowAllFacultiesViewModel>> ShowAllFacultiesForUniversity(int universityId);

        Task AddFaculty(AddFacultyViewModel model);

        Task<EditFacultyViewModel> PrepareForEditFaculty(int id);
        Task EditFaculty(int id, EditFacultyViewModel model);
        Task DeleteFaculty(int id);
    }
}
