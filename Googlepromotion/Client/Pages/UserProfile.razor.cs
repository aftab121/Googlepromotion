using Googlepromotion.Shared.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace Googlepromotion.Client.Pages
{
public partial class UserProfile:ComponentBase
{
        HttpClient http = new HttpClient();
        ResponseModel res = new ResponseModel();
        User[] user;
        private string loader;
        protected override async Task OnInitializedAsync()
        {
            loader = "<div class='loader'><img src='/images/Vp3R.gif'/></div>";
            http.BaseAddress = new Uri(NavManager.Uri);
            var url = NavManager.ToAbsoluteUri(NavManager.Uri);
            var data = await sessionStorage.GetItemAsync<string>("Profile");
           res = await http.GetFromJsonAsync<ResponseModel>("api/signin/GetProfile?useremail="+data);
            if (!res.Status)
            {
            }
            else
            {
                user = JsonSerializer.Deserialize<User[]>(JsonSerializer.Serialize(res.Result), new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                await sessionStorage.SetItemAsync("UserName", user[0].Profile);
            }
            loader = "";
        }
    }
}
