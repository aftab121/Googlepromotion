using Google.GData.Client;
using Googlepromotion.Server.Services;
using Googlepromotion.Shared.Models;
using MailChimp;
using MailChimp.Helper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Googlepromotion.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PromoteBusniessController : ControllerBase
    {
        ResponseModel res = new ResponseModel();
        IAccountService service = new AccountService();
        List<UserContacts> user = new List<UserContacts>();

        [HttpGet]
        public ResponseModel Get(string UserId)
        {
            //service.SavePromoteBusniessDetails(promote1);
            try
            {
                user = service.GetContacts(UserId);

                if (user.Count != 0)
                {

                    foreach (UserContacts Contact in user)
                    {
                      
                        MailChimpManager mc = new MailChimpManager("7c1cf16d68b6794915c9a09c815197e6-us20");
                        EmailParameter email = new EmailParameter()
                        {
                            Email = Contact.Contact
                        };
                        EmailParameter results = mc.Subscribe("5168a5da23", email);
                        var resss = results;
                    }
                }
                res.Result = user;
                res.Status = true;
                return res;
            }
            catch (Exception ex)
            {

            }
            return res;
        }
    }
}
