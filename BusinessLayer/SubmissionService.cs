using BusinessLayer.Contracts;
using DataAccess;
using DataAccess.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class SubmissionService : ISubmissionService
    {
        private readonly IRepository repository;

        public SubmissionService(IRepository repository)
        {
            this.repository = repository;
        }

        public List<SubmissionModel> GetAllSubmissions()
        {
            List<SubmissionModel> result = new List<SubmissionModel>();
            foreach (var x in repository.GetAll<SubmissionEntity>())
            {
                result.Add(new SubmissionModel { SubmissionId = x.SubmissionId, StudentId = x.StudentId, AssignmentId = x.AssignmentId, Comment = x.Comment, GitLink = x.GitLink });
            }
            return result;
        }
        public void AddSubmissionModel(SubmissionModel submission, int StudentId, int AssignmentId)
        {
            var result1 = repository.GetAll<AssignmentEntity>().Where(x => x.AssignmentId == AssignmentId).FirstOrDefault();
            var result2 = repository.GetAll<StudentEntity>().Where(x => x.StudentId == StudentId).FirstOrDefault();

            if (result1 != null && result2!=null)
            {
                repository.Add(new SubmissionEntity { SubmissionId = submission.SubmissionId, StudentId= StudentId, AssignmentId= AssignmentId,Comment = submission.Comment, GitLink = submission.GitLink });
                repository.SaveChanges();
            }

        }

        public void UpdateSubmissionModel(SubmissionModel submission)
        {
            repository.Update(new SubmissionEntity { SubmissionId = submission.SubmissionId, StudentId = submission.StudentId, AssignmentId = submission.AssignmentId, Comment = submission.Comment, GitLink = submission.GitLink });
            repository.SaveChanges();
        }

        public void DeleteSubmissionModel(SubmissionModel submission)
        {
            repository.Delete(new SubmissionEntity { SubmissionId = submission.SubmissionId });
            repository.SaveChanges();
        }

    }
}
