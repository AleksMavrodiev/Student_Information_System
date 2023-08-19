using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using StudentInformationSystem.Data;
using StudentInformationSystem.Services.Contracts;
using StudentInfromationSystem.Data.Models;

namespace StudentInformationSystem.Services.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly StudentInformationDbContext dbContext;

        public UserService(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, StudentInformationDbContext dbContext)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.dbContext = dbContext;
        }
        public async Task AddStudentToRoleAsync(string userId)
        {
            var roleName = "Student";
            var roleExists = await this.roleManager.RoleExistsAsync(roleName);

            if (!roleExists)
            {
                await this.roleManager.CreateAsync(new IdentityRole(roleName));
            }

            var user = await this.userManager.FindByIdAsync(userId);
            var result = await this.userManager.AddToRoleAsync(user, roleName);
        }

        public async Task AddTeacherToRoleAsync(string userId)
        {
            var roleName = "Teacher";
            var roleExists = await this.roleManager.RoleExistsAsync(roleName);

            if (!roleExists)
            {
                await this.roleManager.CreateAsync(new IdentityRole(roleName));
            }

            var user = await this.userManager.FindByIdAsync(userId);
            var result = await this.userManager.AddToRoleAsync(user, roleName);
        }

        public async Task RemoveUserAsync(string id)
        {
            var user = await this.userManager.FindByIdAsync(id);
            await this.userManager.DeleteAsync(user);
            await this.dbContext.SaveChangesAsync();
        }

        public async Task<ApplicationUser> GetUserByIdAsync(string id)
        {
            return await this.userManager.FindByIdAsync(id);
        }
    }
}
