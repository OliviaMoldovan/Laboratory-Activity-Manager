using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Contracts
{
    public class LabModel
    {
        public int LabId { get; set; }

        public int LabNr { get; set; }

        public DateTime Date { get; set; }

        public string Tilte { get; set; }

        public string Objectives { get; set; }

        public string Description { get; set; }

    }
}
