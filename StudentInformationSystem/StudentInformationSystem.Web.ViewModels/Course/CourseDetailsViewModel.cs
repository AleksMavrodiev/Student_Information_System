using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInformationSystem.Data.Models;
using StudentInformationSystem.Web.ViewModels.Student;

namespace StudentInformationSystem.Web.ViewModels.Course
{
    public class CourseDetailsViewModel
    {
        public CourseDetailsViewModel()
        {
            this.Students = new List<StudentCourseDetailsViewModel>();
        }
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public List<StudentCourseDetailsViewModel> Students { get; set; } = null!;
        
    }
}
