using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Web.ViewModels.Course
{
    public class CourseScheduleViewModel
    {
        public string Name { get; set; } = null!;

        public DayOfWeek DayOfWeek { get; set; }
        public TimeOnly Start { get; set; }
        public TimeOnly End { get; set; }
        public int LectureRoom { get; set; }
    }
}
