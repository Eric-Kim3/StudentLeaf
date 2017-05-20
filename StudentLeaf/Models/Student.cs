using StudentLeaf.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentLeaf.Models
{
    public class Student
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public List<ActiveLesson> ActiveLessons { get; set; }
        [Required]
        public List<SessonRecord> History { get; set; }

    }
}