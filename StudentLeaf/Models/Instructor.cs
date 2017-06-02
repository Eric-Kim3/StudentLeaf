using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StudentLeaf.Models
{
    public class Instructor
    {
        
        public int InstructorId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public List<SessonRecord> History { get; set; }

        [Required]
        public float BasePay { get; set; }
    }
}