using System;
using System.ComponentModel.DataAnnotations;

namespace StudentLeaf.Models
{
    public class SessonRecord
    {
        [Required]
        public DateTime DTG { get; set; }
        [Required]
        public int Hours { get; set; }
        [Required]
        public string LessonPlan { get; set; }
        [Required]
        public string Style { get; set; }
        [Required]
        public int InstructorId { get; set; }
        [Required]
        public int TInstructorId { get; set; }
        [Required]
        public int Id { get; set; }



    }
}