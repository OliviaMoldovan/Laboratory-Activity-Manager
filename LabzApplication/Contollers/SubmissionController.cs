using BusinessLayer.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LabzApplication.Contollers
{
    [ApiController]
    [Route("[controller]")]
    public class SubmissionController : ControllerBase
    {
        private readonly ISubmissionService submissionService;
        public SubmissionController(ISubmissionService submissionService)
        {
            this.submissionService = submissionService;
        }

        [HttpGet("View submissions")]
        [Authorize(Roles = "Admin")]

        public IEnumerable<Submission> Get()
        {
            var result = new List<Submission>();
            foreach (var s in submissionService.GetAllSubmissions())
            {
                result.Add(new Submission { SubmissionId = s.SubmissionId, StudentId = s.StudentId, AssignmentId = s.AssignmentId, Comment = s.Comment, GitLink = s.GitLink });
            }
            return result;
        }

        [HttpPost("Create assignment submission")]
        [Authorize(Roles = "User")]
        //[Auth]
        public void Post(Submission submission, int StudentId, int AssignmentId)
        {
            submissionService.AddSubmissionModel(new SubmissionModel { SubmissionId = submission.SubmissionId, StudentId=StudentId, AssignmentId=AssignmentId, Comment = submission.Comment, GitLink = submission.GitLink }, StudentId, AssignmentId);
        }


        [HttpPut("Update assignment submission")]
        [Authorize(Roles = "User")]
        //[Auth] 
        public void Put(Submission submission)
        {
            submissionService.UpdateSubmissionModel(new SubmissionModel { SubmissionId = submission.SubmissionId, StudentId = submission.StudentId, AssignmentId = submission.AssignmentId, Comment = submission.Comment, GitLink = submission.GitLink });
        }

        [HttpDelete("Delete assignment submission")]
        [Authorize(Roles = "User")]
        //[Auth]
        public void Delete(Submission submission)
        {
            submissionService.DeleteSubmissionModel(new SubmissionModel { SubmissionId = submission.SubmissionId });
        }
    }
}
