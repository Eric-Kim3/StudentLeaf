using System.Collections.Generic;

namespace StudentLeaf.Models.ViewModel
{
    public class HistoryInstructorViewModel
    {
        public Student Student { get; set; }
        public Dictionary<int, string> InstructorDictionary { get; set; }
    }
}