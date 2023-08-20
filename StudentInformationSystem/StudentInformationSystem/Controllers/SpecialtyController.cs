using Microsoft.AspNetCore.Mvc;
using StudentInformationSystem.Services.Contracts;
using StudentInformationSystem.Web.ViewModels.Speacialty;

namespace StudentInformationSystem.Controllers
{
    public class SpecialtyController : Controller
    {
        private readonly ISpecialtyService specialtyService;
        private readonly IFacultyService facultyService;

        public SpecialtyController(ISpecialtyService specialtyService, IFacultyService facultyService)
        {
            this.specialtyService = specialtyService;
            this.facultyService = facultyService;
        }

        public async Task<IActionResult> Details(int id)
        {
            var specialty = await this.specialtyService.GetSpecialtyDetailsAsync(id);
            return View(specialty);
        }

        public async Task<IActionResult> All(int id)
        {
            var specialties = await this.specialtyService.GetSpecialtiesForFacultyAsync(id);
            return View(specialties);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var faculties = await this.facultyService.FacultiesForDropDown();
            var model = new SpecialtyAddViewModel()
            {
                Faculties = faculties
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(SpecialtyAddViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await this.specialtyService.AddSpecialtyAsync(model);
            return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await this.specialtyService.GetSpecialtyForEditAsync(id);
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, SpecialtyEditViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            await this.specialtyService.EditSpecialtyAsync(id, model);
            return RedirectToAction("Index", "Home");
        }

        public async Task<IActionResult> Delete(int id)
        {
            await this.specialtyService.DeleteSpecialtyAsync(id);
            return RedirectToAction("Index", "Home");
        }
    }
}
