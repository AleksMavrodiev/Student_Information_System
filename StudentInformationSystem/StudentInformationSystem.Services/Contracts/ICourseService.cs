using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInformationSystem.Web.ViewModels.Course;

namespace StudentInformationSystem.Services.Contracts
{
    public interface ICourseService
    {
        Task<IEnumerable<StudentClassesViewModel>> GetStudentClassesAsync(string studentId);
        Task<IEnumerable<CourseScheduleViewModel>> GetStudentScheduleAsync(string studentId);
        Task<CourseDetailsViewModel> GetCourseDetailsAsync(int courseId);
        Task<EditCourseViewModel> GetCourseForEditAsync(int courseId);
        Task EditCourseAsync(int id, EditCourseViewModel model);
        Task<IEnumerable<CourseAllViewModel>> GetAllCoursesAsync();
        Task CreateCourseAsync(EditCourseViewModel model);
        Task DeleteCourseAsync(int id);
    }
}
