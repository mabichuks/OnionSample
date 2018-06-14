using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Domain.Entities;
using University.Domain.Interfaces;

namespace University.Infrastructure.DataAccess
{
    public class FacultyRepository: UniversityRepository<Faculty>, IFacultyRepository
    {

        public IEnumerable<Faculty> Faculty()
        {
            return ctxt.Faculties;
        }
    }
}
