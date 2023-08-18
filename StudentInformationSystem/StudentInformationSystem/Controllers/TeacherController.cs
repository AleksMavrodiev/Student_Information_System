﻿using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentInformationSystem.Services.Contracts;
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
        public async Task<IActionResult> MySchedule()
        {
            var courses = await this.courseService.GetTeacherScheduleAsync(this.User.FindFirstValue(ClaimTypes.NameIdentifier));

            return View(courses);
        }

        [HttpGet]
        public IActionResult AddTeacher()
        {
            var teacherModel = new TeacherAddViewModel();
            return View(teacherModel);
        }

        [HttpPost]
        public async Task<IActionResult> AddTeacher(TeacherAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.View(model);
            }

            await this.teacherService.AddTeacherAsync(model);

            return this.RedirectToAction("All");
        }

        public async Task<IActionResult> All()
        {
            var teachers = await this.teacherService.GetAllTeachersAsync();

            return this.View(teachers);
        }

        public async Task<IActionResult> MyCourses()
        {
            var courses = await this.teacherService.GetTeacherCoursesAsync(this.User.FindFirstValue(ClaimTypes.NameIdentifier));

            return View(courses);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(string id)
        {
            var teacher = await this.teacherService.GetTeacherForEditAsync(id);
            return View(teacher);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(string id, TeacherEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return this.View(model);
            }

            await this.teacherService.EditTeacherAsync(id, model);

            return this.RedirectToAction("All");
        }

        public async Task<IActionResult> Delete(string id)
        {
            await this.teacherService.DeleteTeacherAsync(id);

            return this.RedirectToAction("All");
        }
    }
}
