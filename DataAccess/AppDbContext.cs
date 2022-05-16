using DataAccess.Contracts;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
       : base(options)
        {
        }
        public DbSet<StudentEntity> StudentEntities { get; set; }

        public DbSet<LabEntity> LabEntities { get; set; }

        public DbSet<AssignmentEntity> AssignmentEntities { get; set; }

        public DbSet<SubmissionEntity> SubmissionEntities { get; set; }

        public DbSet<GradeEntity> GradeEntities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=LAPTOP-F3C6J7K6;Database=dblab;Trusted_Connection=True;");
        }
    }
}
