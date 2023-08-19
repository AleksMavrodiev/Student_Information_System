using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentInformationSystem.Services.Contracts;
using StudentInformationSystem.Web.ViewModels.Student;

namespace StudentInformationSystem.Controllers
{
    [Authorize]
    public class StudentController : Controller
    {
        private readonly IStudentService studentService;
        private readonly ISpecialtyService specialtyService;

        public StudentController(IStudentService studentService, ISpecialtyService specialtyService)
        {
            this.studentService = studentService;
            this.specialtyService = specialtyService;
        }

        public async Task<IActionResult> All()
        {
            var students = await this.studentService.GetStudentsAsync();

            return this.View(students);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Add()
        {
            var studentModel = new StudentAddViewModel();
            studentModel.Specialties = await this.specialtyService.GetSpecialtiesForListItemAsync();
            return View(studentModel);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Add(StudentAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Specialties = await this.specialtyService.GetSpecialtiesForListItemAsync();
                return this.View(model);
            }

            await this.studentService.CreateStudentAsync(model);

            return this.RedirectToAction("All");
        }

        [Authorize(Roles = "Admin,Student")]
        public async Task<IActionResult> MyProfile()
        {
            var student = await this.studentService.GetStudentProfileAsync(this.User.FindFirstValue(ClaimTypes.NameIdentifier));
            return View(student);
        }

        [Authorize(Roles = "Student")]
        [HttpPost]
        public async Task<IActionResult> UploadProfilePicture(IFormFile profilePicture)
        {
            var validImageTypes = new string[] { "image/jpeg", "image/png", "image/gif" };
            if (profilePicture == null)
            {
                TempData["Error"] = "Please Upload a photo";
                return RedirectToAction("MyProfile");
            }
            if (!validImageTypes.Contains(profilePicture.ContentType))
            {
                return RedirectToAction("MyProfile");
            }

            try
            {
                await this.studentService.SaveStudentProfilePictureAsync(this.User.FindFirstValue(ClaimTypes.NameIdentifier), profilePicture);
            }
            catch (Exception e)
            {
                TempData["Error"] = "Please Upload a photo";
                return RedirectToAction("MyProfile");
            }
            return RedirectToAction("MyProfile");
        }

        [HttpPost]
        [Authorize(Roles = "Student")]
        public async Task<IActionResult> RemoveProfilePicture()
        {
            await this.studentService.RemoveStudentProfilePictureAsync(this.User.FindFirstValue(ClaimTypes.NameIdentifier));
            return RedirectToAction("MyProfile");
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(string id)
        {
            var student = await this.studentService.GetStudentEditAsync(id);
            return View(student);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(string id, StudentEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Specialties = await this.specialtyService.GetSpecialtiesForListItemAsync();
                return this.View(model);
            }

            await this.studentService.UpdateStudentAsync(id, model);

            return this.RedirectToAction("All");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(string id)
        {
            await this.studentService.DeleteStudentAsync(id);
            return RedirectToAction("All");
        }
    }
}
