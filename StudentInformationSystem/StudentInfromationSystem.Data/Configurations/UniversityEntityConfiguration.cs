using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentInformationSystem.Data.Models;

namespace StudentInformationSystem.Data.Configurations
{
    public class UniversityEntityConfiguration : IEntityTypeConfiguration<University>
    {
        public void Configure(EntityTypeBuilder<University> builder)
        {
            builder.HasData(this.GenerateUniversities());
        }

        public University[] GenerateUniversities()
        {
            return new University[]
            {
                new University
                {
                    Id = 1,
                    Name = "Technical University of Sofia",
                    Address = "8 Kliment Ohridski Blvd., 1000 Sofia, Bulgaria",
                    PostCode = "1257"
                },
                new University
                {
                    Id = 2,
                    Name = "Sofia University St. Kliment Ohridski",
                    Address = "15 Tsar Osvoboditel Blvd., 1504 Sofia, Bulgaria",
                    PostCode = "1257"
                },
                new University
                {
                    Id = 3,
                    Name = "University of National and World Economy",
                    Address = "8 Kliment Ohridski Blvd., 1000 Sofia, Bulgaria",
                    PostCode = "1257"
                },
            };
        }
    }
}
