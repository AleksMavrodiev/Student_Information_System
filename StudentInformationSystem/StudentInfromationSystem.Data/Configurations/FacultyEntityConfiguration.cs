using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentInformationSystem.Data.Models;

namespace StudentInformationSystem.Data.Configurations
{
    public class FacultyEntityConfiguration : IEntityTypeConfiguration<Faculty>
    {
        public void Configure(EntityTypeBuilder<Faculty> builder)
        {
            builder.HasData(this.GenerateFaculties());
        }

        public Faculty[] GenerateFaculties()
        {
            return new Faculty[]
            {
                new Faculty
                {
                    Id = 1,
                    Name = "Faculty of Mathematics and Informatics",
                    UniversityId = 1
                },
                new Faculty
                {
                    Id = 2,
                    Name = "Faculty of Economics and Business Administration",
                    UniversityId = 2
                },
                new Faculty
                {
                    Id = 3,
                    Name = "Faculty of Law",
                    UniversityId = 3
                },
                new Faculty()
                {
                    Id = 4,
                    Name = "Faculty of German Engineering",
                    UniversityId = 1
                },
                new Faculty()
                {
                    Id = 5,
                    Name = "Faculty of Philosophy",
                    UniversityId = 2
                },
                new Faculty()
                {
                    Id = 6,
                    Name = "Faculty of Computer Systems and Control",
                    UniversityId = 1
                },
            };
        }
    }
}


