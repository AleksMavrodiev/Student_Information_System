using StudentInformationSystem.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static StudentInformationSystem.Common.DataValidationConstants;
using Microsoft.AspNetCore.Mvc.Rendering;

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
        public TimeOnly Start { get; set; }
        public TimeOnly End { get; set; }

        [Required]
        public Guid TeacherId { get; set; }

        public List<SelectListItem> TeacherSelectList { get; set; }
        public List<int> SelectedSpecialtyIds { get; set; }
        public List<SelectListItem> SpecialtyMultiSelectList { get; set; }
    }
}
