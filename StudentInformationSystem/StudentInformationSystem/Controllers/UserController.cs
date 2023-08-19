using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentInformationSystem.Services.Contracts;
using StudentInfromationSystem.Data.Models;

namespace StudentInformationSystem.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly IUserService userService;
        private readonly UserManager<ApplicationUser> userManager;

        public UserController(IUserService userService, UserManager<ApplicationUser> userManager)
        {
            this.userService = userService;
            this.userManager = userManager;
        }                          
            
        [HttpGet]
        public IActionResult GiveStudentRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GiveStudentRole(string username)
        {
            var user = await this.userManager.FindByNameAsync(username);
            await this.userService.AddStudentToRoleAsync(user.Id);
            return RedirectToAction("All", "Student");
        }

        [HttpGet]
        public IActionResult GiveTeacherRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GiveTeacherRole(string username)
        {
            try
            {
                var user = await this.userManager.FindByNameAsync(username);
                await this.userService.AddTeacherToRoleAsync(user.Id);
            }
            catch (Exception e)
            {
                TempData["ErrorMessage"] = "You need to enter a valid teacher username";
                return View();
            }   
            return RedirectToAction("All", "Teacher");
        }
    }
}
