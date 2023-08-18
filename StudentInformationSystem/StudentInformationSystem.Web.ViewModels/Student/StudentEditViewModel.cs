using Microsoft.AspNetCore.Identity;
using StudentInformationSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StudentInformationSystem.Common.DataValidationConstants;
using StudentInformationSystem.Web.ViewModels.Speacialty;

namespace StudentInformationSystem.Web.ViewModels.Student
{
    public class StudentEditViewModel
    {
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

        [Display(Name = "Specialty")]
        public int SpecialtyId { get; set; }
        public IEnumerable<SpecialtyListViewModel>? Specialties { get; set; }
    }
}
