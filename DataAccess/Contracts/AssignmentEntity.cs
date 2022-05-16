using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Contracts
{
    public class AssignmentEntity
    {
        [Key]
        public int AssignmentId { get; set; }

        public string Name { get; set; }

        public DateTime Deadline { get; set; }

        public string Description { get; set; }

        public int LabId { get; set; }

    }
}
