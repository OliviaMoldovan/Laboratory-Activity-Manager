using BusinessLayer.Contracts;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class StudentService : IStudentService
    {
        private readonly IRepository repository;

        public StudentService(IRepository repository)
        {
            this.repository = repository;
        }
        public void AddStudentModel(StudentModel student)
        {
            repository.Add(new StudentEntity { StudentId = student.StudentId, FirstName = student.FirstName, LastName = student.LastName, Group = student.Group, Hobby = student.Hobby });
            repository.SaveChanges();
        }

        public void UpdateStudentModel(StudentModel student)
        {
            repository.Update(new StudentEntity { StudentId = student.StudentId, FirstName = student.FirstName, LastName = student.LastName, Group = student.Group, Hobby = student.Hobby });
            repository.SaveChanges();
        }

        public void DeleteStudentModel(StudentModel student)
        {
            repository.Delete(new StudentEntity { StudentId = student.StudentId});
            repository.SaveChanges();
        }

        public List<StudentModel> GetAllStudents()
        {
            List<StudentModel> result = new List<StudentModel>();
            foreach (var x in repository.GetAll<StudentEntity>())
            {
                result.Add(new StudentModel { StudentId = x.StudentId, FirstName = x.FirstName, LastName = x.LastName, Group = x.Group, Hobby = x.Hobby });
            }
            return result;
        }
    }
}
