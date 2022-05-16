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
    public class LabService : ILabService
    {
        private readonly IRepository repository;

        public LabService(IRepository repository)
        {
            this.repository = repository;
        }
        public void AddLabModel(LabModel lab)
        {
            repository.Add(new LabEntity { LabId=lab.LabId, LabNr=lab.LabNr, Date=lab.Date, Tilte=lab.Tilte, Objectives=lab.Objectives, Description=lab.Description });
            repository.SaveChanges();
        }

        public void UpdateLabModel(LabModel lab)
        {
            repository.Update(new LabEntity { LabId = lab.LabId, LabNr = lab.LabNr, Date = lab.Date, Tilte = lab.Tilte, Objectives = lab.Objectives, Description = lab.Description });
            repository.SaveChanges();
        }

        public void DeleteLabModel(LabModel lab)
        {
            repository.Delete(new LabEntity { LabId = lab.LabId });
            repository.SaveChanges();
        }

        public List<LabModel> GetAllLabs()
        {
            List<LabModel> result = new List<LabModel>();
            foreach (var x in repository.GetAll<LabEntity>())
            {
                result.Add(new LabModel { LabId = x.LabId, LabNr = x.LabNr, Date = x.Date, Tilte = x.Tilte, Objectives = x.Objectives, Description = x.Description });
            }
            return result;
        }
    }
}
