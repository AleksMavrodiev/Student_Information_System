using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentInformationSystem.Services.Contracts;
using StudentInformationSystem.Web.ViewModels.Student;
using StudentInformationSystem.Web.ViewModels.Teacher;

namespace StudentInformationSystem.Controllers
{
    [Authorize]
    public class TeacherController : Controller
    {
        private readonly ICourseService courseService;
        private readonly ITeacherService teacherService;
        public TeacherController(ICourseService courseService, ITeacherService teacherService)
        {
            this.courseService = courseService;
            this.teacherService = teacherService;
        }

        [Authorize(Roles = "Admin,Teacher")]
        public async Task<IActionResult> MySchedule()
        {
            var courses = await this.courseService.GetTeacherScheduleAsync(this.User.FindFirstValue(ClaimTypes.NameIdentifier));

            return View(courses);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public IActionResult AddTeacher()
        {
            var teacherModel = new TeacherAddViewModel();
            return View(teacherModel);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddTeacher(TeacherAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.View(model);
            }

            await this.teacherService.AddTeacherAsync(model);

            return this.RedirectToAction("All");
        }

        public async Task<IActionResult> All(string search)
        {
            var teachers = await this.teacherService.GetAllTeachersAsync(search);

            return this.View(teachers);
        }

        [Authorize(Roles = "Admin,Teacher")]
        public async Task<IActionResult> MyCourses()
        {
            var courses = await this.teacherService.GetTeacherCoursesAsync(this.User.FindFirstValue(ClaimTypes.NameIdentifier));

            return View(courses);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(string id)
        {
            var teacher = await this.teacherService.GetTeacherForEditAsync(id);
            return View(teacher);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(string id, TeacherEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.View(model);
            }

            await this.teacherService.EditTeacherAsync(id, model);

            return this.RedirectToAction("All");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(string id)
        {
            await this.teacherService.DeleteTeacherAsync(id);

            return this.RedirectToAction("All");
        }

        [HttpPost]
        [Authorize(Roles = "Admin,Teacher")]
        public async Task<IActionResult> Grade()
        {
            var studentId = this.Request.Form["studentId"].ToString();
            var courseId = int.Parse(this.Request.Form["courseId"].ToString());
            var grade = int.Parse(this.Request.Form["grade"].ToString());
            await this.teacherService.GradeStudentAsync(studentId, courseId, grade);
            return RedirectToAction("Details", "Course", new {id = courseId});
        }
    }
}
