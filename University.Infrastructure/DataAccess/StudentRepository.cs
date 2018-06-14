using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using University.Domain.Entities;
using University.Domain.Interfaces;

namespace University.Infrastructure.DataAccess
{
    public class StudentRepository : UniversityRepository<Student>, IStudentRepository
    {
      
        public Student GetDetails(Student std)
        {
            return ctxt.Set<Student>().FirstOrDefault(x => x.Id == std.Id);
        }

        public IEnumerable<Student> Students
        {

            get { return ctxt.Students; }
        }
    }
}
