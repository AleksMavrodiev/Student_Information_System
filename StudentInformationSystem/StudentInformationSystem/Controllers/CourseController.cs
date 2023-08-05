using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentInformationSystem.Services.Contracts;

namespace StudentInformationSystem.Controllers
{
    [Authorize]
    public class CourseController : Controller
    {
        private readonly ICourseService courseService;

        public CourseController(ICourseService courseService)
        {
            this.courseService = courseService;
        }
        public async Task<IActionResult> ShowMine()
        {
            string userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            var courses = await this.courseService.GetStudentClasses(userId);

            return View(courses);
        }

        public async Task<IActionResult> Schedule()
        {
            string userId = this.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            var courses = await this.courseService.GetStudentSchedule(userId);

            return View(courses);
        }
    }
}
