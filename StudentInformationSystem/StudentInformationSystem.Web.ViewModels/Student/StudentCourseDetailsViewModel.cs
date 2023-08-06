using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Web.ViewModels.Student
{
    public class StudentCourseDetailsViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
    }
}
