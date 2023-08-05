using Microsoft.EntityFrameworkCore;
using StudentInformationSystem.Data;
using StudentInformationSystem.Services.Contracts;
using StudentInformationSystem.Web.ViewModels.Course;

namespace StudentInformationSystem.Services.Services
{
    public class CourseService : ICourseService
    {
        private readonly StudentInformationDbContext dbContext;

        public CourseService(StudentInformationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IEnumerable<StudentClassesViewModel>> GetStudentClasses(string studentId)
        {
            IEnumerable<StudentClassesViewModel> studentClasses = await this.dbContext.StudentCourses.Where(sc => sc.StudentId.ToString() == studentId)
                .Select(c => new StudentClassesViewModel
                {
                    Id = c.CourseId,
                    Name = c.Course.Name,
                    LectureRoom = c.Course.LectureRoom,
                    Start = c.Course.Start,
                    End = c.Course.End
                }).ToArrayAsync();

            return studentClasses;
        }

        public async Task<IEnumerable<CourseScheduleViewModel>> GetStudentSchedule(string studentId)
        {
            return await this.dbContext.StudentCourses.Where(sc => sc.StudentId.ToString() == studentId).Select(c => new CourseScheduleViewModel
            {
                    Name = c.Course.Name,
                    DayOfWeek = c.Course.DayOfWeek,
                    Start = c.Course.Start,
                    End = c.Course.End,
                    LectureRoom = c.Course.LectureRoom
                }).ToArrayAsync();
        }
    }
}
