using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudentInformationSystem.Common;
using static StudentInformationSystem.Common.DataValidationConstants;

namespace StudentInformationSystem.Data.Models
{
    public class Specialty
    {
        public Specialty()
        {
            this.Students = new HashSet<Student>();
            this.Courses = new HashSet<Course>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(SpecialtyConstants.NameMaxLength, MinimumLength = SpecialtyConstants.NameMinLength)]
        public string Name { get; set; } = null!;

        [ForeignKey(nameof(Faculty))]
        [Required]
        public int FacultyId { get; set; }

        [NotMapped]
        public int CourseCount => Courses.Count;

        [NotMapped]
        public int StudentCount => Students.Count;

        public virtual Faculty Faculty { get; set; } = null!;

        public virtual ICollection<Course> Courses { get; set; } 

        public virtual ICollection<Student> Students { get; set; }
    }
}
