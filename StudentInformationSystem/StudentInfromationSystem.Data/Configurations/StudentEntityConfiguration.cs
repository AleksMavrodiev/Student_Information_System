using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentInformationSystem.Data.Models;

namespace StudentInformationSystem.Data.Configurations
{
    public class StudentEntityConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasOne(s => s.Specialty)
                .WithMany(s => s.Students)
                .HasForeignKey(s => s.SpecialtyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder
                .HasOne(s => s.User)
                .WithOne(u => u.Student)
                .HasForeignKey<Student>(s => s.UserId);

            builder.HasData(this.GenerateStudents());
        }

        public Student[] GenerateStudents()
        {
            return new Student[]
            {
                new Student()
                {
                    Id = Guid.Parse("47af10f2-ef33-4637-a18f-40c27c56acb7"),
                    UserId = "47af10f2-ef33-4637-a18f-40c27c56acb7",
                    SpecialtyId = 1,
                    FacultyNumber = "123456789",
                    IsForeign = false,
                    IsActive = true,
                }
            };
        }
    }
}
