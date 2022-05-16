using BusinessLayer;
using BusinessLayer.Contracts;
using DataAccess;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LabzApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService studentService;
        public StudentController(IStudentService studentService)
        {
            this.studentService = studentService;
        }


        [HttpGet("Get all students")]
        [Authorize(Roles = "Admin")]
        public IEnumerable<Student> Get()
        {
            var result = new List<Student>();
            foreach (var s in studentService.GetAllStudents())
            {
                result.Add(new Student { StudentId = s.StudentId, FirstName = s.FirstName, LastName = s.LastName, Group = s.Group, Hobby = s.Hobby });
            }
            return result;
        }


        [HttpPost("Add student")]
        [Authorize(Roles = "Admin")]
        //[Auth]
        public void Post(Student student)
        {
            studentService.AddStudentModel(new StudentModel { StudentId = student.StudentId, FirstName = student.FirstName, LastName = student.LastName, Group = student.Group, Hobby = student.Hobby });
        }


        [HttpPut("Update student")]
        [Authorize(Roles = "Admin")]
        //[Auth] 
        public void Put(Student student)
        {
            studentService.UpdateStudentModel(new StudentModel { StudentId = student.StudentId, FirstName = student.FirstName, LastName = student.LastName, Group = student.Group, Hobby = student.Hobby });
        }

        [HttpDelete("Delete student")]
        [Authorize(Roles = "Admin")]
        //[Auth]
        public void Delete(Student student)
        {
            studentService.DeleteStudentModel(new StudentModel { StudentId =student.StudentId });
        }
    }
}
