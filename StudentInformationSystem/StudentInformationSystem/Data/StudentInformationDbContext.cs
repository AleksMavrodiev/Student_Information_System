using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using StudentInformationSystem.Data.Models;

namespace StudentInformationSystem.Data
{
    public class StudentInformationDbContext : IdentityDbContext
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

            builder.Entity<Student>()
                .HasOne(s => s.Specialty)
                .WithMany(s => s.Students)
                .HasForeignKey(s => s.SpecialtyId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Teacher>().HasMany(t => t.Courses).WithOne(c => c.Teacher).HasForeignKey(c => c.TeacherId).OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(builder);
        }
    }
}