﻿using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using StudentInfromationSystem.Data.Models;

namespace StudentInfromationSystem.Data.Configurations
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder SeedAdmin(this IApplicationBuilder app)
        {
            using var serviceScope = app.ApplicationServices.CreateScope();
            var services = serviceScope.ServiceProvider;

            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();

            const string adminRole = "Admin";
            Task.Run(async () =>
            {
                if (!await roleManager.RoleExistsAsync(adminRole))
                {
                    var role = new IdentityRole { Name = adminRole };
                    await roleManager.CreateAsync(role);
                }

                var adminUser = await userManager.FindByEmailAsync("admin@mail.com");
                await userManager.AddToRoleAsync(adminUser, adminRole);
            }).GetAwaiter().GetResult();

            return app;
        }
    }
}
