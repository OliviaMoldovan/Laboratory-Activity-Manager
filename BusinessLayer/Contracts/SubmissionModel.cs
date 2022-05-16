using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Contracts
{
    public class SubmissionModel
    {
        public int SubmissionId { get; set; }

        public int StudentId { get; set; }

        public int AssignmentId { get; set; }

        public string Comment { get; set; }

        public string GitLink { get; set; }
    }
}
