using BusinessLayer.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LabzApplication.Contollers
{
    [ApiController]
    [Route("[controller]")]
    public class AssignmentController : ControllerBase
    {
        private readonly IAssignmentService assignmentService;
        public AssignmentController(IAssignmentService assignmentService)
        {
            this.assignmentService = assignmentService;
        }


        [HttpGet("View assignments for laboratory classes")]
        public IEnumerable<Assignment> Get()
        {
            var result = new List<Assignment>();
            foreach (var a in assignmentService.GetAllAssignments())
            {
                result.Add(new Assignment { AssignmentId = a.AssignmentId, Name = a.Name, Deadline = a.Deadline, Description = a.Description });
            }
            return result;
        }


        [HttpPost("Create assignment")]
        [Authorize(Roles = "Admin")]
        //[Auth]
        public void Post(Assignment assignment,int LabId)
        {
            assignmentService.AddAssignmentModel(new AssignmentModel { AssignmentId = assignment.AssignmentId, Name = assignment.Name, Deadline = assignment.Deadline, Description = assignment.Description , LabId = LabId},LabId);
        }


        [HttpPut("Update assignment")]
        [Authorize(Roles = "Admin")]
        //[Auth]
        public void Put(Assignment assignment)
        {
            assignmentService.UpdateAssignmentModel(new AssignmentModel { AssignmentId = assignment.AssignmentId, Name = assignment.Name, Deadline = assignment.Deadline, Description = assignment.Description });
        }

        [HttpDelete("Delete assignment")]
        [Authorize(Roles = "Admin")]
        //[Auth]
        public void Delete(Assignment assignment)
        {
            assignmentService.DeleteAssignmentModel(new AssignmentModel { AssignmentId = assignment.AssignmentId});
        }
    }
}
