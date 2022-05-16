using BusinessLayer.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LabzApplication.Contollers
{
    [ApiController]
    [Route("[controller]")]
    public class LabController : ControllerBase
    {
        private readonly ILabService labService;
        public LabController(ILabService labService)
        {
            this.labService = labService;
        }


        [HttpGet("View a list of all laboratory classes")]
        public IEnumerable<Lab> Get()
        {
            var result = new List<Lab>();
            foreach (var l in labService.GetAllLabs())
            {
                result.Add(new Lab { LabId = l.LabId, LabNr = l.LabNr, Date = l.Date, Tilte = l.Tilte, Objectives = l.Objectives, Description = l.Description });
            }
            return result;
        }


        [HttpPost("Create laboratory class")]
        [Authorize(Roles = "Admin")]
        //[Auth]
        public void Post(Lab lab)
        {
            labService.AddLabModel(new LabModel { LabId = lab.LabId, LabNr = lab.LabNr, Date = lab.Date, Tilte = lab.Tilte, Objectives = lab.Objectives, Description = lab.Description });
        }


        [HttpPut("Update laboratory class")]
        [Authorize(Roles = "Admin")]
        //[Auth]
        public void Put(Lab lab)
        {
            labService.UpdateLabModel(new LabModel { LabId = lab.LabId, LabNr = lab.LabNr, Date = lab.Date, Tilte = lab.Tilte, Objectives = lab.Objectives, Description = lab.Description });
        }

        [HttpDelete("Delete laboratory class")]
        [Authorize(Roles = "Admin")]
        //[Auth]
        public void Delete(Lab lab)
        {
            labService.DeleteLabModel(new LabModel { LabId = lab.LabId});
        }
    }
}
