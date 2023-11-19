using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32.SafeHandles;
using StudentInformationSystem.Services.Contracts;
using StudentInformationSystem.Web.ViewModels.Course;

namespace StudentInformationSystem.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {
        private readonly ITeacherService teacherService;
        private readonly ICourseService courseService;
        private readonly ISpecialtyService specialtyService;
        private readonly IStudentService studentService;

        public CourseController(ICourseService courseService, ITeacherService teacherService, ISpecialtyService specialtyService, IStudentService studentService)
        {
            this.studentService = studentService;
            this.specialtyService = specialtyService;
            this.courseService = courseService;
            this.teacherService = teacherService;
        }

        [Authorize(Roles = "Admin,Student")]
        public async Task<IActionResult> ShowMine()
        {
            string userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            var courses = await this.courseService.GetStudentClassesAsync(userId);

            return View(courses);
        }

        [Authorize(Roles = "Admin,Student")]
        public async Task<IActionResult> Schedule()
        {
            string userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            var courses = await this.courseService.GetStudentScheduleAsync(userId);

            return View(courses);
        }

        public async Task<IActionResult> Details(int id)
        {
            var courseDetails = await this.courseService.GetCourseDetailsAsync(id);

            return View(courseDetails);
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id)
        {
            var course = await this.courseService.GetCourseForEditAsync(id);
            course.Teachers = await this.teacherService.GetTeachersForListItemAsync();
            course.Specialties = await this.specialtyService.GetSpecialtiesForListItemAsync();

            return View(course);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id, EditCourseViewModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorMessage"] = "You should fill all the fields";
                model.Teachers = await this.teacherService.GetTeachersForListItemAsync();
                model.Specialties = await this.specialtyService.GetSpecialtiesForListItemAsync();
                return View(model);
            }

            if (model.Start.Hour >= model.End.Hour || model.End.Hour < model.Start.Hour)
            {
                TempData["ErrorMessage"] = "You should put valid start and end times";
                model.Teachers = await this.teacherService.GetTeachersForListItemAsync();
                model.Specialties = await this.specialtyService.GetSpecialtiesForListItemAsync();
                return View(model);
            }


            await this.courseService.EditCourseAsync(id, model);

            return RedirectToAction("Details", new { id = id });
        }

        public async Task<IActionResult> ShowAll()
        {
            var courses = await this.courseService.GetAllCoursesAsync();

            return View(courses);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var course = new EditCourseViewModel();
            course.Teachers = await this.teacherService.GetTeachersForListItemAsync();
            course.Specialties = await this.specialtyService.GetSpecialtiesForListItemAsync();

            return View(course);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> Add(EditCourseViewModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorMessage"] = "You should fill all the fields";
                model.Teachers = await this.teacherService.GetTeachersForListItemAsync();
                model.Specialties = await this.specialtyService.GetSpecialtiesForListItemAsync();
                return View(model);
            }

            if (model.Start.Hour >= model.End.Hour || model.End.Hour < model.Start.Hour)
            {
                TempData["ErrorMessage"] = "You should put valid start and end times";
                model.Teachers = await this.teacherService.GetTeachersForListItemAsync();
                model.Specialties = await this.specialtyService.GetSpecialtiesForListItemAsync();
                return View(model);
            }

            await this.courseService.CreateCourseAsync(model);

            return RedirectToAction("ShowAll");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            await this.courseService.DeleteCourseAsync(id);

            return RedirectToAction("ShowAll");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddStudents(int id)
        {
            var students = await this.courseService.FetchStudentsForCourseAsync(id);
            ViewBag.CourseId = id;
            return View(students);
        }

        [Authorize(Roles = "Admin,Teacher")]
        [HttpPost]
        public async Task<IActionResult> AddStudentsToCourse(int courseId, string studentEmail)
        {
            var studentId = await this.studentService.GetStudentIdByEmail(studentEmail);

            try
            {
                await this.courseService.EnrollStudentAsync(courseId, studentId);
            }
            catch (Exception e)
            {
                TempData["ErrorMessage"] = e.Message;
                return RedirectToAction("AddStudents", new { id = courseId });
            }

            return RedirectToAction("Details", new { id = courseId });
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> RemoveStudent(int courseId, string studentId)
        {
            await this.courseService.UnenrollStudentAsync(courseId, studentId);

            return RedirectToAction("Details", new { id = courseId });
        }

        public async Task<IActionResult> AddStudentsToCourse(int id)
        {
            ViewData["CourseId"] = id;
            return View();
        }

        public async Task<IActionResult> EditGrade(int courseId, string studentId)
        {
            await this.courseService.ResetGrade(courseId, studentId);
            return RedirectToAction("Details", new { id = courseId });
        }
    }
}
