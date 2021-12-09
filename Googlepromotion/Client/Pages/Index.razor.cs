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
        protected override async Task OnInitializedAsync()
        {
            http.BaseAddress = new Uri(NavManager.Uri);
            var url = NavManager.ToAbsoluteUri(NavManager.Uri);
            var data = await sessionStorage.GetItemAsync<string>("Profile");
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
            }
            NavManager.NavigateTo("/Profile");

        }
    }
}
