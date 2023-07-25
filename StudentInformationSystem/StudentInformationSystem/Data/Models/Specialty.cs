﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using StudentInformationSystem.Common;
using static StudentInformationSystem.Common.DataValidationConstants;

namespace StudentInformationSystem.Data.Models
{
    public class Specialty
    {
        public Specialty()
        {
            this.Students = new HashSet<Student>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(SpecialtyConstants.NameMaxLength, MinimumLength = SpecialtyConstants.NameMinLength)]
        public string Name { get; set; } = null!;

        [ForeignKey(nameof(Faculty))]
        [Required]
        public int FacultyId { get; set; }

        public Faculty Faculty { get; set; } = null!;

        public virtual ICollection<Student> Students { get; set; }
    }
}
