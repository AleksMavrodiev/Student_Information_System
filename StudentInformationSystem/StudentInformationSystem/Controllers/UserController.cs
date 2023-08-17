using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using StudentInformationSystem.Services.Contracts;

namespace StudentInformationSystem.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly IUserService userService;
        private readonly UserManager<IdentityUser> userManager;

        public UserController(IUserService userService, UserManager<IdentityUser> userManager)
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
    }
}
