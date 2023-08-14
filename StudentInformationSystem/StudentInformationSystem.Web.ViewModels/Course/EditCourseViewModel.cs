using StudentInformationSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using static StudentInformationSystem.Common.DataValidationConstants;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentInformationSystem.Web.ViewModels.Speacialty;
using StudentInformationSystem.Web.ViewModels.Teacher;

namespace StudentInformationSystem.Web.ViewModels.Course
{
    public class EditCourseViewModel
    {
        [Required]
        [StringLength(CourseConstants.NameMaxLength, MinimumLength = CourseConstants.NameMinLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(CourseConstants.DescriptionMaxLength, MinimumLength = CourseConstants.DescriptionMinLength)]
        public string Description { get; set; } = null!;

        [Required]
        [Range(CourseConstants.CreditsMinValue, CourseConstants.CreditsMaxValue)]
        public int Credits { get; set; }

        public int LectureRoom { get; set; }

        public DayOfWeek DayOfWeek { get; set; }

        [ModelBinder(typeof(TimeOnlyModelBinder))]
        public TimeOnly Start { get; set; }

        [ModelBinder(typeof(TimeOnlyModelBinder))]
        public TimeOnly End { get; set; }

        [Display(Name="Teacher")]
        public Guid TeacherId { get; set; }

        public IEnumerable<TeacherListViewModel>? Teachers { get; set; }

        [Display(Name="Specialty")]
        public int SpecialtyId { get; set; }
        public IEnumerable<SpecialtyListViewModel>? Specialties { get; set; } 
    }
}
