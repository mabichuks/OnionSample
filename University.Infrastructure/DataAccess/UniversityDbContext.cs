using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Domain.Entities;

namespace University.Infrastructure.DataAccess
{
    public class UniversityDbContext: DbContext
    {
        public UniversityDbContext():base("UniversityDbContext")
        {

        }

        public DbSet<Student> Students { get; set; }

        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
