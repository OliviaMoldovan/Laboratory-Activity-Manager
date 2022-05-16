using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Contracts
{
    public class AssignmentModel
    {
        public int AssignmentId { get; set; }

        public string Name { get; set; }

        public DateTime Deadline { get; set; }
        
        public string Description { get; set; }

        public int LabId { get; set; }

    }
}
