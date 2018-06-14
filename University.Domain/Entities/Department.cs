using System.Collections.Generic;

namespace University.Domain.Entities
{
    public class Department: BaseEntity
    {
        public string Name { get; set; }

        public int FacultyId { get; set; }
        public virtual Faculty Faculty { get; set; }
    }
}