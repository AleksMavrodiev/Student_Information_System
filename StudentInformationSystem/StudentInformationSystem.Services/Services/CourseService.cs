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
                    End = c.Course.End,
                    Grade = c.Grade
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
                    LectureRoom = c.Course.LectureRoom,
                }).ToArrayAsync();
        }

        public async Task<CourseDetailsViewModel> GetCourseDetailsAsync(int courseId)
        {
            var sc = await this.dbContext.Courses.FirstOrDefaultAsync(sc => sc.Id == courseId);

            List<StudentCourseDetailsViewModel> studentNames = await this.dbContext.StudentCourses.Where(sc => sc.CourseId == courseId).Select(s => new StudentCourseDetailsViewModel()
            {
                Id = s.StudentId,
                Name = s.Student.User.FirstName + " " + s.Student.User.LastName
            }).ToListAsync();
            
            
            CourseDetailsViewModel courseDetails = new CourseDetailsViewModel()
            {
                Id = sc.Id,
                Name = sc.Name,
                Description = sc.Description,
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
                TeacherId = (Guid)course.TeacherId,
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

        public async Task CreateCourseAsync(EditCourseViewModel model)
        {
            var course = new Course()
            {
                Name = model.Name,
                Description = model.Description,
                Credits = model.Credits,
                LectureRoom = model.LectureRoom,
                DayOfWeek = model.DayOfWeek,
                Start = model.Start,
                End = model.End,
                TeacherId = model.TeacherId,
                SpecialtyId = model.SpecialtyId,
            };

            await this.dbContext.Courses.AddAsync(course);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task DeleteCourseAsync(int id)
        {
            var course = await this.dbContext.Courses.FirstAsync(c => c.Id == id); 
            this.dbContext.Courses.Remove(course);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task EnrollStudentAsync(int courseId, string studentId)
        {
            try
            {
                await this.dbContext.StudentCourses.AddAsync(new StudentCourses()
                {
                    CourseId = courseId,
                    StudentId = Guid.Parse(studentId),
                    IsEnrolled = true
                });

                await this.dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new InvalidOperationException($"Student with id {studentId} is already enrolled in this course.");
            }
        }

        public async Task UnenrollStudentAsync(int courseId, string studentId)
        {
            var studentCourse = await this.dbContext.StudentCourses.FirstAsync(sc => sc.CourseId == courseId && sc.StudentId.ToString() == studentId);
            studentCourse.IsEnrolled = false;
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<EnrollStudentViewModel>> FetchStudentsForCourseAsync(int id)
        {
            return await this.dbContext.Students.Select(s => new EnrollStudentViewModel()
            {
               StudentId = s.Id,
               FirstName = s.User.FirstName,
               LastName = s.User.LastName,
               FacultyNumber = s.FacultyNumber,
               StudentCourse = this.dbContext.StudentCourses.FirstOrDefault(sc => sc.StudentId == s.Id && sc.CourseId == id) ?? new StudentCourses()
            }).ToArrayAsync();

        }

        public async Task<IEnumerable<CourseScheduleViewModel>> GetTeacherScheduleAsync(string teacherId)
        {
            return await this.dbContext.Courses.Where(c => c.TeacherId.ToString() == teacherId).Select(c => new CourseScheduleViewModel()
            {
                Name = c.Name,
                DayOfWeek = c.DayOfWeek,
                Start = c.Start,
                End = c.End,
                LectureRoom = c.LectureRoom
            }).ToArrayAsync();
        }
    }
}
