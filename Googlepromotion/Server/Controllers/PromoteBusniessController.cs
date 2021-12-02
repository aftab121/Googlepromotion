using Google.GData.Client;
using Googlepromotion.Server.Services;
using Googlepromotion.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Googlepromotion.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromoteBusniessController : ControllerBase
    {
        ResponseModel res = new ResponseModel();
        IAccountService service = new AccountService();
        PromoteBusiness promoteBusiness = new PromoteBusiness();
        [HttpGet]
        public ResponseModel Get(PromoteBusiness promote1)
        {
            service.SavePromoteBusniessDetails(promote1);
            return res;
        }
    }
}
