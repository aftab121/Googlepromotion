using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Threading.Tasks;
using Googlepromotion.Shared.Models;
using System.Net.Http;
using System.Net.Http.Json;
 
namespace Googlepromotion.Client.Pages
{
    public partial class  Index:ComponentBase
    {
        HttpClient http = new HttpClient();
        public string client;
        public string scret;
        public string variable;
        private string loader;
        private string errormsg = "";
        private string User = "";
        protected override async Task OnInitializedAsync()
        {
            http.BaseAddress = new Uri(NavManager.Uri);
            var url = NavManager.ToAbsoluteUri(NavManager.Uri);
            User = await sessionStorage.GetItemAsync<string>("Profile");
        }
        public async Task GetAccessToken()
        {
            loader = "<div class='loader'><img src='/images/Vp3R.gif'/></div>";
            var code = "";
            var uri = NavManager.ToAbsoluteUri(NavManager.Uri);
            if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("code", out var param))
            {
                code = param;
            }
          await LoadOrders(code);
            loader = "";
        }

        private ResponseModel res;
        private async Task LoadOrders(string code)
        {
            http.BaseAddress = new Uri(NavManager.Uri);
            var url = NavManager.ToAbsoluteUri(NavManager.Uri);
            res = await http.GetFromJsonAsync<ResponseModel>("api/signin/get?code=" + code);
            if (res.Status == true)
            {
                await sessionStorage.SetItemAsync("Profile", res.Email);
                //user =JsonSerializer.Deserialize<User>(JsonSerializer.Serialize(res.Result), new JsonSerializerOptions
                //{
                //    PropertyNameCaseInsensitive = true
                //});
                //await sessionStorage.SetItemAsync("Profile", user);
                NavManager.NavigateTo("/Profile");
            }
            else
            {
                errormsg = "Your Token is Expired.Plese Login Again";
            }
            loader = "";
            

        }
        public void googleButton_Click()
        {
            string clientId = "246162259773-vn416ss3gi6h8j444ch8gsllao8v45m9.apps.googleusercontent.com";
            string redirectUrl = "https://localhost:44320/Index";
            // Response.Redirect("https://accounts.google.com/o/oauth2/auth?redirect_uri=" + redirectUrl + "&response_type=code&client_id=" + clientId + "&scope=https://www.google.com/m8/feeds/&approval_prompt=force&access_type=offline");

            //  NavManager.NavigateTo("https://accounts.google.com/o/oauth2/auth?redirect_uri=" + redirectUrl + "&response_type=code&client_id=" + clientId + "&scope=https://www.google.com/m8/feeds/&approval_prompt=force&access_type=offline");

            string url = "https://accounts.google.com/o/oauth2/v2/auth?scope=profile&include_granted_scopes=true&redirect_uri=" + redirectUrl + "&response_type=code&client_id=" + clientId + "";
            NavManager.NavigateTo(url);
        }
    }
}
