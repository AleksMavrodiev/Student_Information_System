﻿using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace StudentInformationSystem.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            builder.HasData(this.GenerateUsers());
        }

        public IdentityUser[] GenerateUsers()
        {
            return new IdentityUser[]
            {
                new IdentityUser()
                {
                    Id = "20661c81-53ef-45dd-ab1c-0c5aee24c90d",
                    Email = "teacher@abv.bg",
                    NormalizedEmail = "teacher@abv.bg",
                    UserName = "teacher@abv.bg"
                },
                new IdentityUser()
                {
                    Id = "47af10f2-ef33-4637-a18f-40c27c56acb7",
                    UserName = "student@university.com",
                    NormalizedUserName = "student@university.com",
                    Email = "student@university.com",
                    NormalizedEmail = "student@university.com"
                }
            };

        }
    }
}
