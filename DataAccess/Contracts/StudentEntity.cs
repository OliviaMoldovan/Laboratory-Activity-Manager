using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class StudentEntity
    {
        [Key]
        public int StudentId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Group { get; set; }

        public string Hobby { get; set; }

    }
}
