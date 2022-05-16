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
    public class GradeService : IGradeService
    {
        private readonly IRepository repository;

        public GradeService(IRepository repository)
        {
            this.repository = repository;
        }
        public void AddGradeModel(GradeModel grade, int SubmissionId)
        {
            var result = repository.GetAll<SubmissionEntity>().Where(x => x.SubmissionId == SubmissionId).FirstOrDefault();
            if (result != null)
            {
                repository.Add(new GradeEntity { GradeId = grade.GradeId, SubmissionId = grade.SubmissionId, Value = grade.Value });
                repository.SaveChanges();
            }
        }

        public void UpdateGradeModel(GradeModel grade)
        {
            repository.Update(new GradeEntity { GradeId = grade.GradeId, SubmissionId = grade.SubmissionId, Value = grade.Value });
            repository.SaveChanges();
        }

        public List<GradeModel> GetAllGrades()
        {
            List<GradeModel> result = new List<GradeModel>();
            foreach (var x in repository.GetAll<GradeEntity>())
            {
                result.Add(new GradeModel { GradeId = x.GradeId, SubmissionId = x.SubmissionId, Value = x.Value });
            }
            return result;
        }
    }
}
