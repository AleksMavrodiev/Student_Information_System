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

            return View(course);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditCourseViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.TeacherSelectList = await this.teacherService.GetTeachersForListItemAsync();
                model.SpecialtyMultiSelectList = await this.specialtyService.GetSpecialtiesForListItemAsync();
                return View(model);
            }

            if (model.Start >= model.End || model.End < model.Start)
            {
                TempData["ErrorMessage"] = "You should put valid start and end times";
                model.TeacherSelectList = await this.teacherService.GetTeachersForListItemAsync();
                model.SpecialtyMultiSelectList = await this.specialtyService.GetSpecialtiesForListItemAsync();
                return View(model);
            }

            TempData["ErrorMessage"] = null;

            await this.courseService.EditCourseAsync(id, model);

            return RedirectToAction("Details", new { id = id });
        }
    }
}
