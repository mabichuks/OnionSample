using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Domain.Entities
{
    public class Student:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }

        public int FacultyId { get; set; }
        public virtual Faculty Faculty { get; set; }

        public int DepartmentId { get; set; }
        public virtual Department Department { get; set; }
        public int Level { get; set; }

    }
}
