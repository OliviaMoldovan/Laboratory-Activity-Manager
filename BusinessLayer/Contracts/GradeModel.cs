using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Contracts
{
    public class GradeModel
    {
        public int GradeId { get; set; }

        public int SubmissionId { get; set; }

        public int Value { get; set; }
    }
}
