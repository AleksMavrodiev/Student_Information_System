using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentInformationSystem.Services.Contracts;
using StudentInformationSystem.Services.Services;
using StudentInformationSystem.Web.ViewModels.University;

namespace StudentInformationSystem.Controllers
{
    [Authorize]
    public class UniversityController : Controller
    {
        private readonly IUniversityService universityService;

        public UniversityController(IUniversityService universityService)
        {
            this.universityService = universityService;
        }
        public async Task<IActionResult> ShowAll()
        {
            var universities = await this.universityService.ShowAll();
            return View(universities);
        }

        [HttpGet]
        public IActionResult Create()
        {
            var universityCreateViewModel = new UniversityCreateViewModel();
            return View(universityCreateViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(UniversityCreateViewModel universityCreateViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(universityCreateViewModel);
            }

            await this.universityService.Create(universityCreateViewModel);
            return RedirectToAction("ShowAll");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var universityEditViewModel = await this.universityService.GetUniversityEditViewModelById(id);
            return View(universityEditViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, UniversityEditViewModel universityEditViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(universityEditViewModel);
            }

            await this.universityService.Edit(id, universityEditViewModel);
            return RedirectToAction("ShowAll");
        }

        public async Task<IActionResult> Delete(int id)
        {
            await this.universityService.Delete(id);
            return RedirectToAction("ShowAll");
        }
    }
}
