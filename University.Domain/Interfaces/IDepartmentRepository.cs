using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Domain.Entities;

namespace University.Domain.Interfaces
{
    public interface IDepartmentRepository: IUniversityRepository<Department>
    {
        IEnumerable<Department> Departments { get; }
    }
}
