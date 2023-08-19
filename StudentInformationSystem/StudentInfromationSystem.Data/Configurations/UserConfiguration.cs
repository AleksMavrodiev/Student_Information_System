using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentInfromationSystem.Data.Models;

namespace StudentInformationSystem.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {

            builder.HasData(this.GenerateUsers());
        }

        public ApplicationUser[] GenerateUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();

            var applicationTeacherUser = new ApplicationUser()
            {
                Id = "85b57b7c2aac4db78a70dd2ff901b895",
                FirstName = "Ivan",
                LastName = "Ivanov",
                Email = "ivan.ivanov@abv.bg",
                NormalizedEmail = "ivan.ivanov@abv.bg",
                UserName = "ivan.ivanov@abv.bg",
                EGN = "1234567890",
                PhoneNumber = "0888123456",
                PasswordRequiredChange = true
            };

            var studentApplicationUser = new ApplicationUser()
            {
                Id = "47af10f2-ef33-4637-a18f-40c27c56acb7",
                UserName = "student@university.com",
                NormalizedUserName = "student@university.com",
                Email = "student@university.com",
                NormalizedEmail = "student@university.com",
                FirstName = "Aleksandar",
                LastName = "Aleksandrov",
                EGN = "1234567890",
                PhoneNumber = "0888123456",
                PasswordRequiredChange = true
            };


            const string password = "admin";
            const string email = "admin@mail.com";

            var adminUser = new ApplicationUser()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = email,
                NormalizedUserName = email,
                Email = email,
                NormalizedEmail = email,
                FirstName = "Admin",
                LastName = "Adminov",
                EGN = "1234567890",
                PhoneNumber = "0888123456",
                PasswordRequiredChange = false
            };
            adminUser.PasswordHash = hasher.HashPassword(adminUser, password);

            studentApplicationUser.PasswordHash = hasher.HashPassword(studentApplicationUser, "1234");

            applicationTeacherUser.PasswordHash = hasher.HashPassword(applicationTeacherUser, "1234");

            return new ApplicationUser[]
            {
                applicationTeacherUser,
                studentApplicationUser,
                adminUser
            };

        }
    }
}
