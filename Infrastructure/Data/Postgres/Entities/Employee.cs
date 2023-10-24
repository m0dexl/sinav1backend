using Infrastructure.Data.Postgres.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data.Postgres.Entities
{
    public class Employee : Entity<int>
    {
        public string Date_Of_Birth { get; set; } 
        public string Phone_Number { get; set; }

        public int User_Id { get; set; }
        public User User { get; set; }

        public int Department_Id { get; set; }
        public Department Department { get; set; }
    }
}
