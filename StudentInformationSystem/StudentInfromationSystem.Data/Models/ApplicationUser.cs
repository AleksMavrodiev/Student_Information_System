using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using StudentInformationSystem.Data.Models;
using static StudentInformationSystem.Common.DataValidationConstants;

namespace StudentInfromationSystem.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(StudentConstants.FirstNameMaxLength, MinimumLength = StudentConstants.FirstNameMinLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [StringLength(StudentConstants.LastNameMaxLength, MinimumLength = StudentConstants.LastNameMinLength)]
        public string LastName { get; set; } = null!;
        
        [Required]
        [StringLength(StudentConstants.EGNMaxLength)]
        public string EGN { get; set; } = null!;

        public byte[]? ProfilePicture { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Student Student { get; set; }
        public bool PasswordRequiredChange { get; set; }
    }
}
