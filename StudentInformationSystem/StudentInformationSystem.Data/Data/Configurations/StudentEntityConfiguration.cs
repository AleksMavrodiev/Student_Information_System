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

            

            builder.HasData(this.GenerateStudents());
        }

        public Student[] GenerateStudents()
        {
            return new Student[]
            {
                new Student()
                {
                    Id = Guid.NewGuid(),
                    FirstName = "Ivan",
                    LastName = "Ivanov",
                    Email = "student@university.com",
                    EGN = "1234567890",
                    UserId = "47af10f2-ef33-4637-a18f-40c27c56acb7",
                    PhoneNumber = "0888123456",
                    SpecialtyId = 1,
                    FacultyNumber = "123456789",
                    IsForeign = false,
                    IsActive = true,
                }
            };
        }
    }
}
