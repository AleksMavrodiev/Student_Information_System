using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Web.ViewModels.Speacialty
{
    public class SpecialtyDetailsViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int CourseCount { get; set; }
        public int StudentCount { get; set; }
        public virtual ICollection<Data.Models.Course>? Courses { get; set; }

        public virtual ICollection<Data.Models.Student>? Students { get; set; }
    }
}
