using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Contracts
{
    public interface IGradeService
    {
        List<GradeModel> GetAllGrades();

        void AddGradeModel(GradeModel grade, int SubmissionId);

        void UpdateGradeModel(GradeModel grade);

    }
}
