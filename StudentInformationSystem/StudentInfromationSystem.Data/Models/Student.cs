using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudentInfromationSystem.Data.Models;
using static StudentInformationSystem.Common.DataValidationConstants;

namespace StudentInformationSystem.Data.Models
{
    public class Student
    {
        public Student()
        {
            this.Id = Guid.NewGuid();
            this.StudentCourses = new HashSet<StudentCourses>();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [StringLength(StudentConstants.FacultyNumberMaxLength, MinimumLength = StudentConstants.FacultyNumberMinLength)]
        public string FacultyNumber { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public bool IsForeign { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }

        public virtual ApplicationUser User { get; set; }

        [Required]
        [ForeignKey(nameof(Specialty))]
        public int SpecialtyId { get; set; }

        public virtual Specialty Specialty { get; set; } = null!;

        public virtual ICollection<StudentCourses> StudentCourses { get; set; }

    }
}
