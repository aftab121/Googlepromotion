using System;
using System.Collections.Generic;
using System.Text;

namespace Googlepromotion.Shared.Models
{
   public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Contacts { get; set; }
        public bool status { get; set; }
        public DateTime create_Date { get; set; }

        public static implicit operator User(ResponseModel v)
        {
            throw new NotImplementedException();
        }
    }
    public class UserContacts
    {
       
        public string Contact { get; set; }
    }
}
