using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentInformationSystem.Data.Models;

namespace StudentInformationSystem.Data.Configurations
{
    public class SpecialtyEntityConfiguration : IEntityTypeConfiguration<Specialty>
    {
        public void Configure(EntityTypeBuilder<Specialty> builder)
        {
            builder.HasData(this.GenerateSpecialties());
        }

        public Specialty[] GenerateSpecialties()
        {
            return new Specialty[]
            {
                new Specialty()
                {
                    Id = 1,
                    Name = "Computer Science",
                    FacultyId = 1
                },
                new Specialty()
                {
                    Id = 2,
                    Name = "Software Engineering",
                    FacultyId = 1
                },
                new Specialty()
                {
                    Id = 3,
                    Name = "Business Administration",
                    FacultyId = 2
                },
                new Specialty()
                {
                    Id = 4,
                    Name = "Law",
                    FacultyId = 3
                },
            };
        }
    }
}
