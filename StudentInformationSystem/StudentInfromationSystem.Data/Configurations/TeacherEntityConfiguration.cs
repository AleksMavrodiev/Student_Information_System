using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentInformationSystem.Data.Models;
using StudentInfromationSystem.Data.Models;

namespace StudentInformationSystem.Data.Configurations
{
    public class TeacherEntityConfiguration : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder
                .HasOne(t => t.User)
                .WithOne(u => u.Teacher)
                .HasForeignKey<Teacher>(t => t.UserId)
                .OnDelete(DeleteBehavior.Restrict);

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
                    UserId = "85b57b7c2aac4db78a70dd2ff901b895",
                },
            };
        }
    }
}
