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
    public class AssignmentService : IAssignmentService
    {
        private readonly IRepository repository;

        public AssignmentService(IRepository repository)
        {
            this.repository = repository;
        }
        public void AddAssignmentModel(AssignmentModel assignment, int LabId)
        {
            var result = repository.GetAll<LabEntity>().Where(x => x.LabId == LabId).FirstOrDefault();
            if (result != null)
            {
                repository.Add(new AssignmentEntity { AssignmentId = assignment.AssignmentId, Name = assignment.Name, Deadline = assignment.Deadline, Description = assignment.Description ,LabId=LabId});
                repository.SaveChanges();
            }
        }

        public void UpdateAssignmentModel(AssignmentModel assignment)
        {
            repository.Update(new AssignmentEntity { AssignmentId = assignment.AssignmentId, Name = assignment.Name, Deadline = assignment.Deadline, Description = assignment.Description ,LabId=assignment.LabId});
            repository.SaveChanges();
        }

        public void DeleteAssignmentModel(AssignmentModel assignment)
        {
            repository.Delete(new AssignmentEntity { AssignmentId = assignment.AssignmentId});
            repository.SaveChanges();
        }

        public List<AssignmentModel> GetAllAssignments()
        {
            List<AssignmentModel> result = new List<AssignmentModel>();
            foreach (var x in repository.GetAll<AssignmentEntity>())
            {
                result.Add(new AssignmentModel { AssignmentId = x.AssignmentId, Name = x.Name, Deadline = x.Deadline, Description = x.Description,LabId=x.LabId });
            }
            return result;
        }
    }
}
