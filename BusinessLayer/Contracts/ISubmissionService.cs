using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Contracts
{
    public interface ISubmissionService
    {
        List<SubmissionModel> GetAllSubmissions();

        void AddSubmissionModel(SubmissionModel submission, int StudentId, int AssignmentId);

        void UpdateSubmissionModel(SubmissionModel submission);

        void DeleteSubmissionModel(SubmissionModel submission);
    }
}
