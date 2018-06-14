using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Domain.Entities;
using University.Domain.Interfaces;

namespace University.Infrastructure.DataAccess
{
    public class DepartmentRepository : UniversityRepository<Department>, IDepartmentRepository
    {

        public IEnumerable<Department> Departments
        {
            get { return ctxt.Departments; }
        }
    }
}
