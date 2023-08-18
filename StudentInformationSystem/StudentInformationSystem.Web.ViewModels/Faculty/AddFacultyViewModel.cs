using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInformationSystem.Web.ViewModels.University;
using static StudentInformationSystem.Common.DataValidationConstants;

namespace StudentInformationSystem.Web.ViewModels.Faculty
{
    public class AddFacultyViewModel
    {
        [Required]
        [StringLength(FacultyConstants.NameMaxLength, MinimumLength = FacultyConstants.NameMinLength)]
        public string Name { get; set; } = null!;

        public string? ImageUrl { get; set; }

        [Required]
        [StringLength(FacultyConstants.DescriptionMaxLength, MinimumLength = FacultyConstants.DescriptionMinLength)]
        public string Description { get; set; } = null!;

        public int UniversityId { get; set; }

        public IEnumerable<UniversityListViewModel>? Universities { get; set; }
    }
}
