using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [StringLength(StudentConstants.FirstNameMaxLength, MinimumLength = StudentConstants.FirstNameMinLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(StudentConstants.LastNameMaxLength, MinimumLength = StudentConstants.LastNameMinLength)]
        public string LastName { get; set; } = null!;

        [Required]
        [StringLength(StudentConstants.EGNMaxLength)]
        public string EGN { get; set; } = null!;

        [Required]
        [StringLength(StudentConstants.EmailMaxLength, MinimumLength = StudentConstants.EmailMinLength)]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(StudentConstants.FacultyNumberMaxLength, MinimumLength = StudentConstants.FacultyNumberMinLength)]
        public string FacultyNumber { get; set; }

        [Required]
        [StringLength(StudentConstants.PhoneNumberMaxLength, MinimumLength = StudentConstants.PhoneNumberMinLength)]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public bool IsForeign { get; set; }

        [Required]
        [ForeignKey(nameof(Specialty))]
        public int SpecialtyId { get; set; }

        public Specialty Specialty { get; set; } = null!;

        public virtual ICollection<StudentCourses> StudentCourses { get; set; }

    }
}
