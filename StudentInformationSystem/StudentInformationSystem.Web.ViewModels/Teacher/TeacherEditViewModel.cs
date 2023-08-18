using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StudentInformationSystem.Common.DataValidationConstants;

namespace StudentInformationSystem.Web.ViewModels.Teacher
{
    public class TeacherEditViewModel
    {
        public string Id { get; set; } = null!;

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
    }
}
