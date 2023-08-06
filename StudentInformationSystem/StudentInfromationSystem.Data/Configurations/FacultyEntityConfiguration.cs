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
                    Description = "The Faculty of Mathematics and Informatics is one of the largest faculties of Sofia University. It was founded in 1888. In 1963 the Faculty of Mathematics and Mechanics was divided into two separate faculties: the Faculty of Mathematics and the Faculty of Mechanics.",
                    ImageUrl = "https://www.fmi.uni-sofia.bg/sites/default/files/fmi.jpg",
                    UniversityId = 1
                },
                new Faculty
                {
                    Id = 2,
                    Name = "Faculty of Economics and Business Administration",
                    Description = "The Faculty of Economics and Business Administration is the oldest and largest faculty of Sofia University. It was founded in 1905 as a Higher School of Commerce. In 1920 it was transformed into the Faculty of Commerce and Economics, and in 1940 it was renamed the Faculty of Economics.",
                    ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/d/db/FEBA-SPRING.jpg",
                    UniversityId = 2
                },
                new Faculty
                {
                    Id = 3,
                    Name = "Faculty of Law",
                    Description = "The Faculty of Law is the oldest faculty of Sofia University. It was founded in 1892 as a Higher School of Law. In 1904 it was transformed into the Faculty of Law.",
                    ImageUrl = "https://law.uni-sofia.bg/sites/default/files/2019-09/429_2.jpg",
                    UniversityId = 3
                },
                new Faculty()
                {
                    Id = 4,
                    Name = "Faculty of German Engineering",
                    Description = "The Faculty of German Engineering was founded in 1941 as a Higher School of Mechanical and Electrical Engineering. In 1945 it was renamed the Higher School of Mechanical and Electrical Engineering in German. In 1947 it was transformed into the Faculty of German Engineering.",
                    ImageUrl = "https://fdiba.tu-sofia.bg/wp-content/uploads/2022/02/Building-10B-1.jpg",
                    UniversityId = 1
                },
                new Faculty()
                {
                    Id = 5,
                    Name = "Faculty of Philosophy",
                    Description = "The Faculty of Philosophy is the oldest faculty of Sofia University. It was founded in 1888 as a Higher School of Philosophy. In 1904 it was transformed into the Faculty of Philosophy.",
                    ImageUrl = "https://phls.uni-sofia.bg/documents/articles/111/colliseum-4.jpg",
                    UniversityId = 2
                },
                new Faculty()
                {
                    Id = 6,
                    Name = "Faculty of Computer Systems and Control",
                    Description = "The Faculty of Computer Systems and Control was founded in 1963 as a Higher School of Computer Systems and Control. In 1963 it was transformed into the Faculty of Computer Systems and Control.",
                    ImageUrl = "https://www.tu-college.com/wp-content/uploads/2020/06/cropped-tu.jpg",
                    UniversityId = 1
                },
            };
        }
    }
}


