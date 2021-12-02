using Googlepromotion.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Googlepromotion.Server.Services
{
   public interface IAccountService
    {
        public abstract bool SaveUserDetails(User user,List<UserContacts> contacts);
        public abstract List<User> GetProfile(string Username);
      public abstract bool SavePromoteBusniessDetails(PromoteBusiness promote);

    }
}
