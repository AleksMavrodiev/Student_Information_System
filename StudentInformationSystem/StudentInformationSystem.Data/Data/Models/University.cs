using System.ComponentModel.DataAnnotations;
using static StudentInformationSystem.Common.DataValidationConstants;

namespace StudentInformationSystem.Data.Models
{
    public class University
    {
        public University()
        {
            this.Faculties = new HashSet<Faculty>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(UniversityConstants.NameMaxLength, MinimumLength = UniversityConstants.NameMinLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(UniversityConstants.AddressMaxLength, MinimumLength = UniversityConstants.AddressMinLength)]
        public string Address { get; set; } = null!;

        [Required]
        [StringLength(UniversityConstants.PostCodeMaxLength, MinimumLength = UniversityConstants.PostCodeMinLength)]
        public string PostCode { get; set; } = null!;

        public virtual ICollection<Faculty> Faculties { get; set; }
    }
}
