using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInformationSystem.Web.ViewModels.Faculty;
using static StudentInformationSystem.Common.DataValidationConstants;

namespace StudentInformationSystem.Web.ViewModels.Speacialty
{
    public class SpecialtyAddViewModel
    {

        [Required]
        [StringLength(SpecialtyConstants.NameMaxLength, MinimumLength = SpecialtyConstants.NameMinLength)]
        public string Name { get; set; } = null!;
        public int FacultyId { get; set; }
        public IEnumerable<FacultyListViewModel>? Faculties { get; set; }
    }
}
