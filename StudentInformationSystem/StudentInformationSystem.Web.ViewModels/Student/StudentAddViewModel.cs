using Microsoft.AspNetCore.Identity;
using StudentInformationSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInformationSystem.Web.ViewModels.Speacialty;
using static StudentInformationSystem.Common.DataValidationConstants;

namespace StudentInformationSystem.Web.ViewModels.Student
{
    public class StudentAddViewModel
    {
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

        public byte[]? ProfilePicture { get; set; }

        [Required]
        public bool IsActive { get; set; }

        [Required]
        public bool IsForeign { get; set; }

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; } = null!;

        public virtual IdentityUser<Guid> User { get; set; }

        [Required]
        [ForeignKey(nameof(Specialty))]
        public int SpecialtyId { get; set; }

        public IEnumerable<SpecialtyListViewModel> Specialties { get; set; } 
    }
}
