using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentInformationSystem.Data.Models;

namespace StudentInfromationSystem.Data.Configurations
{
    public class StudentCourseEntityConfigurations : IEntityTypeConfiguration<StudentCourses>
    {
        public void Configure(EntityTypeBuilder<StudentCourses> builder)
        {
            builder.HasOne(sc => sc.Student).WithMany(s => s.StudentCourses).HasForeignKey(sc => sc.StudentId);

            builder.HasOne(sc => sc.Course).WithMany(c => c.StudentCourses).HasForeignKey(sc => sc.CourseId);

            builder.HasData(this.GenerateStudentCourses());
        }

        public StudentCourses[] GenerateStudentCourses()
        {
            return new StudentCourses[]
            {
                new StudentCourses()
                {
                    StudentId = Guid.Parse("47af10f2-ef33-4637-a18f-40c27c56acb7"),
                    CourseId = 1
                },
                new StudentCourses()
                {
                    StudentId = Guid.Parse("47af10f2-ef33-4637-a18f-40c27c56acb7"),
                    CourseId = 2
                },
                new StudentCourses()
                {
                    StudentId = Guid.Parse("47af10f2-ef33-4637-a18f-40c27c56acb7"),
                    CourseId = 3
                },
            };
        }
    }
}
