using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Department : Entity<int>
    {
        public string Department_Name { get; set; }
        public ICollection<Employee> Employees { get; set; }
    }
}
