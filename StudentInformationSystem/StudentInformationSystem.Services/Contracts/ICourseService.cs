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
        Task<IEnumerable<StudentClassesViewModel>> GetStudentClasses(string studentId);
        Task<IEnumerable<CourseScheduleViewModel>> GetStudentSchedule(string studentId);
        Task<CourseDetailsViewModel> GetCourseDetails(int courseId);
    }
}
