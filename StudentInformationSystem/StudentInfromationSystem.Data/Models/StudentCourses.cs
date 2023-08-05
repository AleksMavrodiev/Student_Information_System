using System.ComponentModel.DataAnnotations.Schema;

namespace StudentInformationSystem.Data.Models
{
    public class StudentCourses
    {
        [ForeignKey(nameof(Student))]
        public Guid StudentId { get; set; }
        public Student Student { get; set; } = null!;

        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }
        public Course Course { get; set; } = null!;

        public double Grade { get; set; }
    }
}
