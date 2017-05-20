using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentLeaf.Models
{
    public class ActiveLesson
    {
        [Required]
        [Display(Name = "Active Lesson Plan")]
        public string LessonPlan { get; set; }
        [Required]
        [Display(Name = "Dance Style")]
        public string Style { get; set; }
        [Required]
        [Display(Name = "Remaining Hours")]
        public double Hours { get; set; }
        [Required]
        [Display(Name = "Selling Instructor")]
        public string SInstructor { get; set; }
        [Required]
        public int Id { get; set; }
    }
}