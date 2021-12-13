using Google.Contacts;
using Google.GData.Client;
using Google.GData.Contacts;
using Google.GData.Extensions;
using Googlepromotion.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Googlepromotion.Server.Services;
using Nancy.Json;


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
        [HttpGet]
        public ResponseModel Get(string code)
        {
            string result = ReceiveTokenGmail(code);
            res.Message = "";
            res.Status = true;
            user.Contacts = result;
            user.status = true;
            user.create_Date = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            res.Result = user;
            res.Email= user.Email;
            service.SaveUserDetails(user,contacts);
            if(user==null&&contacts.Count==0)
            {
                res.Status = false;
            }
            return res;
        }
        public string GetContacts(GooglePlusAccessToken serStatus)
        {
            try { 
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
            RequestSettings settings = new RequestSettings("<var>Google Promotion</var>", oAuthparameters);
            ContactsRequest cr = new ContactsRequest(settings);
            ContactsQuery query = new ContactsQuery(ContactsQuery.CreateContactsUri("default"));
            query.NumberToRetrieve = 500;
            Feed<Contact> feed = cr.Get<Contact>(query);
            List<UserContacts> user = new List<UserContacts>();
            StringBuilder sb = new StringBuilder();
            int i = 1;
            foreach (Contact entry in feed.Entries)
            {
                foreach (EMail email in entry.Emails)
                {
                    user.Add(new UserContacts() { Contact = email.Address });
                }
            }
            contacts.AddRange(user);
            }
            catch(Exception ex)
            {

            }
            return "true";
        }
        string url = "https://accounts.google.com/o/oauth2/token";
        public string ReceiveTokenGmail(string code)
        {
            try { 
            string google_client_id = "246162259773-vn416ss3gi6h8j444ch8gsllao8v45m9.apps.googleusercontent.com";
            string google_client_sceret = "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";
            string google_redirect_url = "https://localhost:44320/Index";
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
            string data = GetContacts(serStatus);
            GetuserProfile(serStatus.access_token);
            }
            catch(Exception ex)
            {
            }
            return url;
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
        public void GetuserProfile(string accesstoken)
        {
            string url = "https://www.googleapis.com/oauth2/v3/userinfo?alt=json&access_token=" + accesstoken + "";
            WebRequest request = WebRequest.Create(url);
            request.Credentials = CredentialCache.DefaultCredentials;
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            reader.Close();
            response.Close();
            JavaScriptSerializer js = new JavaScriptSerializer();
            Userclass userinfo = js.Deserialize<Userclass>(responseFromServer);
            user.Email = userinfo.email;
            user.UserName = userinfo.name;
            user.Profile = userinfo.picture;

        }
    }
}

