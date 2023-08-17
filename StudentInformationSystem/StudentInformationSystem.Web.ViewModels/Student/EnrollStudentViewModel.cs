using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentInformationSystem.Data.Models;

namespace StudentInformationSystem.Web.ViewModels.Student
{
    public class EnrollStudentViewModel
    {
        public Guid StudentId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string FacultyNumber { get; set; }
        public StudentCourses StudentCourse { get; set; }
    }
}
