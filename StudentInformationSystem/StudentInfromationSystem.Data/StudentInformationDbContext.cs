using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentInformationSystem.Data.Configurations;
using StudentInformationSystem.Data.Models;
using StudentInfromationSystem.Data.Configurations;
using StudentInfromationSystem.Data.Models;

namespace StudentInformationSystem.Data
{
    public class StudentInformationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public StudentInformationDbContext(DbContextOptions<StudentInformationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Student> Students { get; set; } = null!;
        public DbSet<University> Universities { get; set; } = null!;
        public DbSet<Faculty> Faculties { get; set; } = null!;
        public DbSet<Specialty> Specialties { get; set; } = null!;
        public DbSet<Course> Courses { get; set; } = null!;
        public DbSet<StudentCourses> StudentCourses { get; set; } = null!;
        public DbSet<Teacher> Teachers { get; set; } = null!;


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<StudentCourses>().HasKey(sc => new { sc.StudentId, sc.CourseId });

            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new UniversityEntityConfiguration());
            builder.ApplyConfiguration(new FacultyEntityConfiguration());
            builder.ApplyConfiguration(new SpecialtyEntityConfiguration());
            builder.ApplyConfiguration(new TeacherEntityConfiguration());
            builder.ApplyConfiguration(new CourseEntityConfiguration());
            builder.ApplyConfiguration(new StudentEntityConfiguration());
            builder.ApplyConfiguration(new StudentCourseEntityConfigurations());
            base.OnModelCreating(builder);
        }
    }
}