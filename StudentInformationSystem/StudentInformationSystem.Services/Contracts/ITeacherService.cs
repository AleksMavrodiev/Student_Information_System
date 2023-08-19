using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentInformationSystem.Web.ViewModels.Course;
using StudentInformationSystem.Web.ViewModels.Teacher;

namespace StudentInformationSystem.Services.Contracts
{
    public interface ITeacherService
    {
        Task<IEnumerable<TeacherListViewModel>> GetTeachersForListItemAsync();
        Task AddTeacherAsync(TeacherAddViewModel model);
        Task<IEnumerable<TeacherAllViewModel>> GetAllTeachersAsync(string search);
        Task<IEnumerable<TeacherCoursesViewModel>> GetTeacherCoursesAsync(string teacherId);
        Task<TeacherEditViewModel> GetTeacherForEditAsync(string teacherId);
        Task EditTeacherAsync(string id, TeacherEditViewModel model);
        Task DeleteTeacherAsync(string id);
        Task GradeStudentAsync(string studentId, int courseId, int grade);
    }
}
