using BusinessLayer.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LabzApplication.Contollers
{
    [ApiController]
    [Route("[controller]")]
    public class GradeController : ControllerBase
    {
        private readonly IGradeService gradeService;
        public GradeController(IGradeService gradeService)
        {
            this.gradeService = gradeService;
        }


        [HttpGet("Get all grades")]
        [Authorize(Roles = "Admin")]
        public IEnumerable<Grade> Get()
        {
            var result = new List<Grade>();
            foreach (var g in gradeService.GetAllGrades())
            {
                result.Add(new Grade { GradeId=g.GradeId, SubmissionId=g.SubmissionId, Value=g.Value });
            }
            return result;
        }


        [HttpPost("Grade assignment submission")]
        [Authorize(Roles = "Admin")]
        //[Auth]
        public void Post(Grade grade,int SubmissionId)
        {
            gradeService.AddGradeModel(new GradeModel { GradeId = grade.GradeId, SubmissionId = grade.SubmissionId, Value = grade.Value }, SubmissionId);
        }


        [HttpPut("Update grade for an assignment submission")]
        [Authorize(Roles = "Admin")]
        //[Auth] 
        public void Put(Grade grade)
        {
            gradeService.UpdateGradeModel(new GradeModel { GradeId = grade.GradeId, SubmissionId = grade.SubmissionId, Value = grade.Value });
        }

    }
}
