using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;
using StudentInfromationSystem.Data.Models;
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

        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; } = null!;

        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
