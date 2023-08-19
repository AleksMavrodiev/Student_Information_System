using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentInformationSystem.Services.Contracts;
using StudentInformationSystem.Web.ViewModels.Faculty;

namespace StudentInformationSystem.Controllers
{
    public class FacultyController : Controller
    {
        private readonly IFacultyService facultyService;
        private readonly IUniversityService universityService;

        public FacultyController(IFacultyService facultyService, IUniversityService universityService)
        {
            this.facultyService = facultyService;
            this.universityService = universityService;
        }

        [HttpGet]
        public async Task<IActionResult> ShowAllForUniversity(int id)
        {
            var faculties = await this.facultyService.ShowAllFacultiesForUniversity(id);

            return View(faculties);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Add()
        {
            var specialty = new AddFacultyViewModel();
            specialty.Universities = await this.universityService.GetUniversitiesForDropDownAsync();
            return View(specialty);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Add(AddFacultyViewModel model)
        {
            await this.facultyService.AddFaculty(model);
            return RedirectToAction("ShowAll", "University");
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id)
        {
            var faculty = await this.facultyService.PrepareForEditFaculty(id);
            return View(faculty);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id, EditFacultyViewModel model)
        {
            if (!ModelState.IsValid)
            {
                TempData["ErrorMessage"] = "Invalid data.";
                model.Universities = await this.universityService.GetUniversitiesForDropDownAsync();
                return View(model);
            }
            await this.facultyService.EditFaculty(id, model);
            return RedirectToAction("ShowAll", "University");
        }

        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            await this.facultyService.DeleteFaculty(id);
            return RedirectToAction("ShowAll", "University");
        }
    }
}
