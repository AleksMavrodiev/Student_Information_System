using Microsoft.AspNetCore.Mvc;
using StudentInformationSystem.Services.Contracts;

namespace StudentInformationSystem.Controllers
{
    public class FacultyController : Controller
    {
        private readonly IFacultyService facultyService;

        public FacultyController(IFacultyService facultyService)
        {
            this.facultyService = facultyService;
        }

        [HttpGet]
        public async Task<IActionResult> ShowAllForUniversity(int id)
        {
            var faculties = await this.facultyService.ShowAllFacultiesForUniversity(id);

            return View(faculties);
        }
    }
}
