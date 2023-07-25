using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using static StudentInformationSystem.Common.DataValidationConstants;

namespace StudentInformationSystem.Data.Models
{
    public class Teacher
    {
        public Teacher()
        {
            this.Id = Guid.NewGuid();
            this.Courses = new HashSet<Course>();
        }

        public Guid Id { get; set; }

        [StringLength(TeacherConstants.FirstNameMaxLength, MinimumLength = TeacherConstants.FirstNameMinLength)]
        public string FirstName { get; set; } = null!;

        [StringLength(TeacherConstants.LastNameMaxLength, MinimumLength = TeacherConstants.LastNameMinLength)]
        public string LastName { get; set; } = null!;

        [StringLength(TeacherConstants.EGNMaxLength)]
        public string EGN { get; set; } = null!;

        [StringLength(TeacherConstants.EmailMaxLength, MinimumLength = TeacherConstants.EmailMinLength)]
        public string Email { get; set; } = null!;

        [StringLength(TeacherConstants.PhoneNumberMaxLength, MinimumLength = TeacherConstants.PhoneNumberMinLength)]

        public string PhoneNumber { get; set; } = null!;

        [Required]
        public string UserId { get; set; } = null!;

        public virtual IdentityUser User { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
