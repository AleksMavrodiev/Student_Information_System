using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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

        public CourseController(ICourseService courseService, ITeacherService teacherService, ISpecialtyService specialtyService)
        {
            this.specialtyService = specialtyService;
            this.courseService = courseService;
            this.teacherService = teacherService;
        }
        public async Task<IActionResult> ShowMine()
        {
            string userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            var courses = await this.courseService.GetStudentClassesAsync(userId);

            return View(courses);
        }

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

        public async Task<IActionResult> Edit(int id)
        {
            var course = await this.courseService.GetCourseForEditAsync(id);
            course.Teachers = await this.teacherService.GetTeachersForListItemAsync();
            course.Specialties = await this.specialtyService.GetSpecialtiesForListItemAsync();

            return View(course);
        }

        [HttpPost]
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
    }
}
