using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts
{
    public class SubmissionEntity
    {
        [Key]

        public int SubmissionId { get; set; }

        public int StudentId { get; set; }

        public int AssignmentId { get; set; }

        public string Comment { get; set; }

        public string GitLink { get; set; }
    }
}
