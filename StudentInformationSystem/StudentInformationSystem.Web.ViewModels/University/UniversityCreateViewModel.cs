using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StudentInformationSystem.Common.DataValidationConstants;

namespace StudentInformationSystem.Web.ViewModels.University
{
    public class UniversityCreateViewModel
    {
        [Required]
        [StringLength(UniversityConstants.NameMaxLength, MinimumLength = UniversityConstants.NameMinLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(UniversityConstants.AddressMaxLength, MinimumLength = UniversityConstants.AddressMinLength)]
        public string Address { get; set; } = null!;

        [Required]
        [StringLength(UniversityConstants.PostCodeMaxLength, MinimumLength = UniversityConstants.PostCodeMinLength)]
        public string PostCode { get; set; } = null!;
    }
}
