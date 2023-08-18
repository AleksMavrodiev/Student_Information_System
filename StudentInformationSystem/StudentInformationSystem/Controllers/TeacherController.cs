using System.Security.Claims;
using Microsoft.AspNetCore.Mvc;
using StudentInformationSystem.Services.Contracts;

namespace StudentInformationSystem.Controllers
{
    public class TeacherController : Controller
    {
        private readonly ICourseService courseService;

        public TeacherController(ICourseService courseService)
        {
            this.courseService = courseService;
        }
        public async Task<IActionResult> MySchedule()
        {
            var courses = await this.courseService.GetTeacherScheduleAsync(this.User.FindFirstValue(ClaimTypes.NameIdentifier));

            return View(courses);
        }
    }
}
