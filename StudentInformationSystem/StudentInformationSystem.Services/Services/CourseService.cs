using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentInformationSystem.Data;
using StudentInformationSystem.Data.Models;
using StudentInformationSystem.Services.Contracts;
using StudentInformationSystem.Web.ViewModels.Course;
using StudentInformationSystem.Web.ViewModels.Student;

namespace StudentInformationSystem.Services.Services
{
    public class CourseService : ICourseService
    {
        private readonly StudentInformationDbContext dbContext;

        public CourseService(StudentInformationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<IEnumerable<StudentClassesViewModel>> GetStudentClassesAsync(string studentId)
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

        public async Task<IEnumerable<CourseScheduleViewModel>> GetStudentScheduleAsync(string studentId)
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

        public async Task<CourseDetailsViewModel> GetCourseDetailsAsync(int courseId)
        {
            List<StudentCourseDetailsViewModel> studentNames = await this.dbContext.StudentCourses.Where(sc => sc.CourseId == courseId).Select(s => new StudentCourseDetailsViewModel()
            {
                Id = s.StudentId,
                Name = s.Student.FirstName + " " + s.Student.LastName
            }).ToListAsync();
            StudentCourses sc = await this.dbContext.StudentCourses.FirstOrDefaultAsync(sc => sc.CourseId == courseId);
            
            CourseDetailsViewModel courseDetails = new CourseDetailsViewModel()
            {
                Id = sc.CourseId,
                Name = sc.Course.Name,
                Description = sc.Course.Description,
                Students = studentNames
            };

            return courseDetails;
        }

        public async Task<EditCourseViewModel> GetCourseForEditAsync(int courseId)
        {

            var course = await this.dbContext.Courses.FirstAsync(c => c.Id == courseId);

            return new EditCourseViewModel()
            {
                Name = course.Name,
                Description = course.Description,
                Credits = course.Credits,
                LectureRoom = course.LectureRoom,
                DayOfWeek = course.DayOfWeek,
                Start = course.Start,
                End = course.End,
                TeacherId = course.TeacherId,
                SpecialtyId = course.SpecialtyId
            };
        }

        public Task EditCourseAsync(int id, EditCourseViewModel model)
        {
            var course = this.dbContext.Courses.First(c => c.Id == id);
            if (course == null)
            {
                throw new InvalidOperationException($"Course with id {id} does not exist.");
            }

            course.Name = model.Name;
            course.Description = model.Description;
            course.Credits = model.Credits;
            course.LectureRoom = model.LectureRoom;
            course.DayOfWeek = model.DayOfWeek;
            course.Start = model.Start;
            course.End = model.End;
            course.TeacherId = model.TeacherId;
            course.SpecialtyId = model.SpecialtyId;

            return this.dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<CourseAllViewModel>> GetAllCoursesAsync()
        {
            return await this.dbContext.Courses.Select(c => new CourseAllViewModel()
            {
                Id = c.Id,
                Name = c.Name,
                Description = c.Description,
                Credits = c.Credits,
                StudentsCount = dbContext.StudentCourses.Count(sc => sc.CourseId == c.Id)
            }).ToArrayAsync();
        }
    }
}
