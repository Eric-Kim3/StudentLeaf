using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentLeaf.Models
{
    public class SessonRecord
    {
        [Required]
        public DateTime DTG { get; set; }
        [Required]
        public string LessonPlan { get; set; }
        [Required]
        public string Style { get; set; }
        [Required]
        public int InstructorId { get; set; }
        [Required]
        public int SInstructorId { get; set; }
        [Required]
        public int Id { get; set; }

    }
}