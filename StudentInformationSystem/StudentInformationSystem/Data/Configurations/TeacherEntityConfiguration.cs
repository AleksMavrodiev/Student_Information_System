using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentInformationSystem.Data.Models;

namespace StudentInformationSystem.Data.Configurations
{
    public class TeacherEntityConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasMany(t => t.Courses).WithOne(c => c.Teacher).HasForeignKey(c => c.TeacherId).OnDelete(DeleteBehavior.Restrict);

            builder.HasData(this.GenerateTeachers());
        }

        public Teacher[] GenerateTeachers()
        {
            return new Teacher[]
            {
                new Teacher()
                {
                    Id = Guid.Parse("20661c81-53ef-45dd-ab1c-0c5aee24c90d"),
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    Email = "teacher@abv.bg",
                    EGN = "1234567890",
                    UserId = "20661c81-53ef-45dd-ab1c-0c5aee24c90d",
                    PhoneNumber = "0888123456",
                },
            };
        }
    }
}
