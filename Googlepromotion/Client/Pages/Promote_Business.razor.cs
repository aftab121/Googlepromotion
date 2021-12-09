using Googlepromotion.Shared.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace Googlepromotion.Client.Pages
{
    public partial class Promote_Business:ComponentBase
    {
        HttpClient http = new HttpClient();
        private ResponseModel res;
        User[] user;
        PromoteBusiness promote = new PromoteBusiness();
        public string errorMessage = string.Empty;
        protected override async Task OnInitializedAsync()
        {
            http.BaseAddress = new Uri(NavManager.Uri);
            var url = NavManager.ToAbsoluteUri(NavManager.Uri);
            var data = await sessionStorage.GetItemAsync<string>("Profile");
            promote.UserId = data;
        }
            protected async Task PromoteBusinessForm()
        {
            http.BaseAddress = new Uri(NavManager.Uri);
            string id = promote.UserId;
        res = await http.GetFromJsonAsync<ResponseModel>("api/PromoteBusniess/Get?UserId=" + id + "");
            if (res.Status != true)
            {
                errorMessage = res.Message;
            }
            else
            {
                //                userco = JsonSerializer.Deserialize<UserContacts[]>(JsonSerializer.Serialize(res.Result), new JsonSerializerOptions
                //{
                //});
                // res.Result

                // }
                //await sessionStorage.SetItemAsync("Employee", employee);
                NavManager.NavigateTo("/Home");
            }
        }
    }
}
