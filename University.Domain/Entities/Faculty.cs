using System.Collections.Generic;

namespace University.Domain.Entities
{
    public class Faculty: BaseEntity
    {
        public string Name { get; set; }
        public virtual List<Department> Departments { get; set; }
    }
}