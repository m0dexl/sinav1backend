using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Models.Request.Create
{
    public class EmployeeCreateDto
    {
        public string Date_Of_Birth { get; set; }
        public string Phone_Number { get; set; }
        public int User_Id { get; set; }
        public int Department_Id {  get; set; }
    }
}
