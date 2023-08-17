﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using StudentInformationSystem.Services.Contracts;

namespace StudentInformationSystem.Services.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public UserService(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
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
    }
}