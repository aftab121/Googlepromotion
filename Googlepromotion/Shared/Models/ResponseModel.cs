using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Googlepromotion.Shared.Models
{
    public class ResponseModel
    {
        public string Message { get; set; }
        public bool Status { get; set; }
        public dynamic Result { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
