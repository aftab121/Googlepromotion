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
        public string Profile { get; set; }
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
    public class Userclass
    {
        public string id { get; set; }
        public string name { get; set; }
        public string given_name { get; set; }
        public string family_name { get; set; }
        public string link { get; set; }
        public string picture { get; set; }
        public string gender { get; set; }
        public string locale { get; set; }
        public string email { get; set; }
        public bool email_verified { get; set; }
    }
}
