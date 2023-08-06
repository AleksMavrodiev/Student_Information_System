using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static StudentInformationSystem.Common.DataValidationConstants;

namespace StudentInformationSystem.Data.Models
{
    public class Faculty
    {
        public Faculty()
        {
            this.Specialties = new HashSet<Specialty>();
        }
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(FacultyConstants.NameMaxLength, MinimumLength = FacultyConstants.NameMinLength)]
        public string Name { get; set; } = null!;
        
        public string ImageUrl { get; set; }

        [Required]
        [StringLength(FacultyConstants.DescriptionMaxLength, MinimumLength = FacultyConstants.DescriptionMinLength)]
        public string Description { get; set; }

        [ForeignKey(nameof(University))]
        public int UniversityId { get; set; }

        public virtual University University { get; set; } = null!;

        public virtual ICollection<Specialty> Specialties { get; set; }
    }
}
