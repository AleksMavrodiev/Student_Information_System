﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformationSystem.Web.ViewModels.Course
{
    public class StudentClassesViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int LectureRoom { get; set; }
        public TimeOnly Start { get; set; }
        public TimeOnly End { get; set; }
        public double? Grade { get; set; }
    }
}
