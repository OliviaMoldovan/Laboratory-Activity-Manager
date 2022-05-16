using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts
{
    public class GradeEntity
    {
        [Key]
        public int GradeId { get; set; }

        public int SubmissionId { get; set; }

        public int Value { get; set; }
    }
}
