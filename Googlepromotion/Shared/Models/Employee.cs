using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Googlepromotion.Shared.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public int LoginCount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Approved { get; set; }

        public string RoleName { get; set; }
    }
}
