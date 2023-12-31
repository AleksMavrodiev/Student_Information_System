﻿using System.ComponentModel.DataAnnotations.Schema;

namespace StudentInformationSystem.Data.Models
{
    public class StudentCourses
    {
        [ForeignKey(nameof(Student))]
        public Guid StudentId { get; set; }
        public virtual Student Student { get; set; } = null!;

        [ForeignKey(nameof(Course))]
        public int CourseId { get; set; }
        public virtual Course Course { get; set; } = null!;

        public double Grade { get; set; }

        public bool IsEnrolled { get; set; }
    }
}
