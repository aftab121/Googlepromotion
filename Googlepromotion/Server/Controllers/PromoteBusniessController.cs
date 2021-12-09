using Googlepromotion.Server.Services;
using Googlepromotion.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using MailChimp.Net;
using MailChimp.Net.Core;
using MailChimp.Net.Models;
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
            try
            {
                //CreateAndSendCampaign(UserId);
                user = service.GetContacts(UserId);

                //if (user.Count != 0)
                //{

                //    foreach (UserContacts Contact in user)
                //    {

                //        MailChimpManager mc = new MailChimpManager("7c1cf16d68b6794915c9a09c815197e6-us20");
                //        EmailParameter email = new EmailParameter()
                //        {
                //            Email = Contact.Contact
                //        };
                //        EmailParameter results = mc.Subscribe("5168a5da23", email);
                //        var resss = results;
                //    }
                //}
                //res.Result = user;
                //res.Status = true;

                var ApiKey = "540ff7c127fd55daddfe9cabb9ddcc14-us20";
                int TemplateId = 1;
                MailChimpManager _mailChimpManager = new MailChimpManager(ApiKey);
                var list = _mailChimpManager.Lists.AddOrUpdateAsync(new List() { Contact = new Contact() { Address1 = "test5" }, });
                var r = _mailChimpManager.Lists.GetAllAsync().GetAwaiter();
                var m = _mailChimpManager.Members.AddOrUpdateAsync(list.Id.ToString(),
                    new Member
                    {
                        EmailAddress = "poonam@nextolive.com.com",
                        EmailType = "html",
                        Status = Status.Subscribed
                    });
                var _campaignSettings = new Setting
                {
                    ReplyTo = "test.nextolive@gmail.com",
                    FromName = "The name that others will see when they receive the email",
                    Title = "Email1",
                    SubjectLine = "For Mailchimp Testing",
                };
                var campaign = _mailChimpManager.Campaigns.AddAsync(new Campaign
                {
                    Settings = _campaignSettings,
                    Recipients = new Recipient { ListId = "5168a5da23" },
                    Type = CampaignType.Regular
                }).Result;
                var timeStr = DateTime.Now.ToString();
                var content = _mailChimpManager.Content.AddOrUpdateAsync(
                 campaign.Id,
                 new ContentRequest()
                 {
                     Template = new ContentTemplate
                     {
                         Id = TemplateId,
                         Sections = new Dictionary<string, object>()
                                                    {
                                       { "body_content", "<h1>Test</h1>" },
                                       { "preheader_leftcol_content", $"<p>{timeStr}</p>" }
                                                    }
                     }
                 }).Result;
                _mailChimpManager.Campaigns.SendAsync(campaign.Id).Wait();
                return res;
            }
            catch (Exception ex)
            {
            }
            return res;
        }
      //  private const string ApiKey = "(7c1cf16d68b6794915c9a09c815197e6-us20)";
      //  private const string ListId = "(5168a5da23)";
       // private const int TemplateId = 9999; // (your template id)
       // private MailChimpManager _mailChimpManager = new MailChimpManager(ApiKey);
       // private Setting _campaignSettings = new Setting
       // {
       //     ReplyTo = "your@email.com",
       //     FromName = "The name that others will see when they receive the email",
       //     Title = "Your campaign title",
       //     SubjectLine = "The email subject",
       // };
       // public void CreateAndSendCampaign(string html)
       // {
       //     var campaign = _mailChimpManager.Campaigns.AddAsync(new Campaign
       //     {
       //         Settings = _campaignSettings,
       //         Recipients = new Recipient { ListId = ListId },
       //         Type = CampaignType.Regular
       //     }).Result;
       //     var timeStr = DateTime.Now.ToString();
       //     var content = _mailChimpManager.Content.AddOrUpdateAsync(
       //      campaign.Id,
       //      new ContentRequest()
       //      {
       //          Template = new ContentTemplate
       //          {
       //              Id = TemplateId,
       //              Sections = new Dictionary<string, object>()
       //         {
       //{ "body_content", html },
       //{ "preheader_leftcol_content", $"<p>{timeStr}</p>" }
       //         }
       //          }
       //      }).Result;
       //     _mailChimpManager.Campaigns.SendAsync(campaign.Id).Wait();
       // }
       // public List<Template> GetAllTemplates()
       //   => _mailChimpManager.Templates.GetAllAsync().Result.ToList();
       // public List<List> GetAllMailingLists()
       //   => _mailChimpManager.Lists.GetAllAsync().Result.ToList();
       // public Content GetTemplateDefaultContent(string templateId)
       //   => (Content)_mailChimpManager.Templates.GetDefaultContentAsync(templateId).Result;
    }
}

