using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Manage.Internal;
using Microsoft.AspNetCore.Mvc;
using StudentInformationSystem.Services.Contracts;
using StudentInformationSystem.Web.ViewModels.User;
using StudentInfromationSystem.Data.Models;

namespace StudentInformationSystem.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private readonly IUserService userService;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;

        public UserController(IUserService userService, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            this.userService = userService;
            this.userManager = userManager;
            this.signInManager = signInManager;
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

        [HttpGet]
        public IActionResult ChangePassword(string email)
        {
            var model = new ChangePasswordViewModel();
            model.Email = email;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(string email, ChangePasswordViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.Email = email;
                var user = await userManager.FindByNameAsync(User.Identity.Name);

                if (user != null)
                {
                    var signInResult = await signInManager.CheckPasswordSignInAsync(user, model.OldPassword, lockoutOnFailure: false);

                    if (signInResult.Succeeded)
                    {
                        var changePasswordResult = await userManager.ChangePasswordAsync(user, model.OldPassword, model.NewPassword);

                        if (changePasswordResult.Succeeded)
                        {
                            user.PasswordRequiredChange = false;
                            await this.signInManager.SignInAsync(user, isPersistent: false);
                            return RedirectToAction("Index", "Home");
                        }
                        else
                        {
                            foreach (var error in changePasswordResult.Errors)
                            {
                                ModelState.AddModelError(string.Empty, error.Description);
                            }
                        }
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Invalid old password.");
                    }
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "User not found.");
                }
            }
            return View();
        }
    }
}
