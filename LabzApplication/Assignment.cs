using System;

namespace LabzApplication
{
    public class Assignment
    {
        public int AssignmentId { get; set; }

        public string Name { get; set; }

        public DateTime Deadline { get; set; }

        public string Description { get; set; }

        public int LabId { get; set; }

        //plus lab id
    }
}
