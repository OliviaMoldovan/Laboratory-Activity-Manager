using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Contracts
{
    public interface IAssignmentService
    {
        List<AssignmentModel> GetAllAssignments();

        void AddAssignmentModel(AssignmentModel assignment, int LabId);

        void UpdateAssignmentModel(AssignmentModel assignment);

        void DeleteAssignmentModel(AssignmentModel assignment);
    }
}
