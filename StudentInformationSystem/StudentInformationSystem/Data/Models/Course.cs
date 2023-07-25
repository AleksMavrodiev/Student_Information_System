using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudentInformationSystem.Common;
using static StudentInformationSystem.Common.DataValidationConstants;

namespace StudentInformationSystem.Data.Models
{
    public class Course
    {
        public Course()
        {
            this.StudentCourses = new HashSet<StudentCourses>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(CourseConstants.NameMaxLength, MinimumLength = CourseConstants.NameMinLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(CourseConstants.DescriptionMaxLength, MinimumLength = CourseConstants.DescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Required]
        [Range(CourseConstants.CreditsMinValue, CourseConstants.CreditsMaxValue)]
        public int Credits { get; set; }

        public int LectureRoom { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        [Required]
        [ForeignKey(nameof(Teacher))]
        public Guid TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }

        [Required]
        [ForeignKey(nameof(Specialty))]
        public int SpecialtyId { get; set; }

        public virtual Specialty Specialty { get; set; } = null!;

        public virtual ICollection<StudentCourses> StudentCourses { get; set; }
    }
}
