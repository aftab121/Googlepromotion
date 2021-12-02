using Google.Contacts;
using Google.GData.Client;
using Google.GData.Contacts;
using Google.GData.Extensions;
using Googlepromotion.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Googlepromotion.Server.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Googlepromotion.Server.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SignInController : ControllerBase
    {
        List<UserContacts> contacts = new List<UserContacts>();
        ResponseModel res = new ResponseModel();
        IAccountService service = new AccountService();
        User user = new User();
        // GET: api/<MyLoginController>
        [HttpGet]
        public ResponseModel Get(string code)
        {
            //redirect_uri = "https://localhost:44320/Index";
            string result = ReceiveTokenGmail(code);
            res.Message = "";
            res.Status = true;
             user.Email = "test.nextolive@gmail.com";
           // user.Email = "poonampcc94@gmail.com";
            user.Contacts = result;
            user.UserName = "Next Olive";
            //user.UserName = "Poonam Yadav";
            user.status = true;
            user.create_Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            res.Result = user.Email;
            res.Email= user.Email;
            service.SaveUserDetails(user,contacts);
            return res;
        }

        //public ResponseModel Get(User user)
        //{

        //    return res;
        //}
        public string GetContacts(GooglePlusAccessToken serStatus)
        {
            string refreshToken = serStatus.refresh_token;
            string accessToken = serStatus.access_token;
            string scopes = "https://www.google.com/m8/feeds/contacts/default/full/";
            OAuth2Parameters oAuthparameters = new OAuth2Parameters()
            {
                RedirectUri = "https://localhost:44320/Index",
                Scope = scopes,
                AccessToken = accessToken,
                RefreshToken = refreshToken
            };
            RequestSettings settings = new RequestSettings("<var>YOUR_APPLICATION_NAME</var>", oAuthparameters);
            ContactsRequest cr = new ContactsRequest(settings);
            ContactsQuery query = new ContactsQuery(ContactsQuery.CreateContactsUri("default"));
            query.NumberToRetrieve = 5000;
            Feed<Contact> feed = cr.Get<Contact>(query);
            List<UserContacts> user = new List<UserContacts>();
            //UserContacts user = new UserContacts();
            StringBuilder sb = new StringBuilder();
            int i = 1;
            foreach (Contact entry in feed.Entries)
            {
                foreach (EMail email in entry.Emails)
                {
                    //sb.Append(i + "&nbsp;").Append(email.Address).Append("<br/>");
                    //i++;
                    user.Add(new UserContacts() { Contact = email.Address });
                    
                }
               // contacts.AddRange(user);
            }
            contacts.AddRange(user);
            var data = sb.ToString();
            return data;
        }
        public string ReceiveTokenGmail(string code)
        {

            string google_client_id = "246162259773-vn416ss3gi6h8j444ch8gsllao8v45m9.apps.googleusercontent.com";
            string google_client_sceret = "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";
            string google_redirect_url = "https://localhost:44320/Index";
            // code = param;
            HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("https://accounts.google.com/o/oauth2/token");
            webRequest.Method = "POST";
            string parameters = "code=" + code + "&client_id=" + google_client_id + "&client_secret=" + google_client_sceret + "&redirect_uri=" + google_redirect_url + "&grant_type=authorization_code";
            byte[] byteArray = Encoding.UTF8.GetBytes(parameters);
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.ContentLength = byteArray.Length;
            Stream postStream = webRequest.GetRequestStream();
            postStream.Write(byteArray, 0, byteArray.Length);
            postStream.Close();
            WebResponse response = webRequest.GetResponse();
            postStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(postStream);
            string responseFromServer = reader.ReadToEnd();
            GooglePlusAccessToken serStatus = JsonConvert.DeserializeObject<GooglePlusAccessToken>(responseFromServer);
            /*End*/
            string data = GetContacts(serStatus);
            return data;
        }
        public ResponseModel GetProfile(string useremail)
        {
            ResponseModel res = new ResponseModel();
            List<User> lst = new List<User>();
            lst = service.GetProfile(useremail);
            if (lst.Count > 0)
            {
                res.Status = true;
                res.Result = lst;
            }
            else
                res.Status = false;
            return res;
        }
    }
}

