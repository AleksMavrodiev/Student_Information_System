using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentInformationSystem.Data.Models;

namespace StudentInformationSystem.Data.Configurations
{
    public class CourseEntityConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.Property(c => c.Start).HasConversion<TimeOnlyConverter, TimeOnlyComparer>();
            builder.Property(c => c.End).HasConversion<TimeOnlyConverter, TimeOnlyComparer>();

            builder.HasData(this.GenerateCourses());
        }

        public Course[] GenerateCourses()
        {
            return new Course[]
            {
                new Course()
                {
                    Id = 1,
                    Name = "Mathematics",
                    Description = "Mathematics is the study of numbers, shapes and patterns. The word comes from the Greek word (mathema), meaning science, knowledge, or learning, and is sometimes shortened to maths (in England, Australia, Ireland, and New Zealand) or math (in the United States and Canada).",
                    Credits = 6,
                    LectureRoom = 101,
                    Start = TimeOnly.Parse("10:00:00"),
                    End = TimeOnly.Parse("11:30:00"),
                    TeacherId = Guid.Parse("20661c81-53ef-45dd-ab1c-0c5aee24c90d"),
                    SpecialtyId = 1
                },
                new Course()
                {
                    Id = 2,
                    Name = "Algorithms and Data Structures",
                    Description = "An algorithm is a set of instructions designed to perform a specific task. This can be a simple process, such as multiplying two numbers, or a complex operation, such as playing a compressed video file. Search engines use proprietary algorithms to display the most relevant results from their search index for specific queries.",
                    Credits = 10,
                    LectureRoom = 102,
                    Start = TimeOnly.Parse("12:00:00"),
                    End = TimeOnly.Parse("13:30:00"),
                    TeacherId = Guid.Parse("20661c81-53ef-45dd-ab1c-0c5aee24c90d"),
                    SpecialtyId = 1
                },
                new Course()
                {
                    Id = 3,
                    Name = "Object-Oriented Programming",
                    Description = "Object-oriented programming (OOP) is a programming paradigm based on the concept of \"objects\", which can contain data and code: data in the form of fields (often known as attributes or properties), and code, in the form of procedures (often known as methods).",
                    Credits = 8,
                    LectureRoom = 103,
                    Start = TimeOnly.Parse("14:00:00"),
                    End = TimeOnly.Parse("15:30:00"),
                    TeacherId = Guid.Parse("20661c81-53ef-45dd-ab1c-0c5aee24c90d"),
                    SpecialtyId = 1
                },
                new Course()
                {
                    Id = 4,
                    Name = "Software Engineering",
                    SpecialtyId = 2,
                    Description = "Software engineering is the systematic application of engineering approaches to the development of software. Software engineering is a computing discipline.",
                    Credits = 8,
                    LectureRoom = 104,
                    Start = TimeOnly.Parse("16:00:00"),
                    End = TimeOnly.Parse("17:30:00"),
                    TeacherId = Guid.Parse("20661c81-53ef-45dd-ab1c-0c5aee24c90d")
                },
                new Course()
                {
                    Id = 5,
                    Name = "Business Administration",
                    SpecialtyId = 3,
                    Description = "Business administration is the process of managing a business or non-profit organization so that it remains stable and continues to grow. This consists of a number of areas, ranging from operations to management.",
                    Credits = 8,
                    LectureRoom = 201,
                    Start = TimeOnly.Parse("10:00:00"),
                    End = TimeOnly.Parse("11:30:00"),
                    TeacherId = Guid.Parse("20661c81-53ef-45dd-ab1c-0c5aee24c90d")
                },
                new Course()
                {
                    Id = 6,
                    Name = "Law",
                    SpecialtyId = 4,
                    Description = "Law is a system of rules created and enforced through social or governmental institutions to regulate behavior, with its precise definition a matter of longstanding debate. It has been variously described as a science and the art of justice.",
                    Credits = 8,
                    LectureRoom = 202,
                    Start = TimeOnly.Parse("12:00:00"),
                    End = TimeOnly.Parse("13:30:00"),
                    TeacherId = Guid.Parse("20661c81-53ef-45dd-ab1c-0c5aee24c90d")
                },
            };
        }
    }
}
