using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Contracts
{
    public interface ILabService
    {
        List<LabModel> GetAllLabs();

        void AddLabModel(LabModel lab);

        void UpdateLabModel(LabModel lab);

        void DeleteLabModel(LabModel lab);
    }
}
