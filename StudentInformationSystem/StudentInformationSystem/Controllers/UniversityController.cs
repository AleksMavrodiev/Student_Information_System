using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using StudentInformationSystem.Services.Contracts;
using StudentInformationSystem.Services.Services;

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
    }
}
