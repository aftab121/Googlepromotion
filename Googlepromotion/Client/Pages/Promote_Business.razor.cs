using Googlepromotion.Shared.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace Googlepromotion.Client.Pages
{
    public partial class Promote_Business:ComponentBase
    {

        HttpClient http = new HttpClient();
        ResponseModel res = new ResponseModel();
        User[] user;
        PromoteBusiness promote = new PromoteBusiness();
        public string errorMessage = string.Empty;
        protected override async Task OnInitializedAsync()
        {

            http.BaseAddress = new Uri(NavManager.Uri);
            var url = NavManager.ToAbsoluteUri(NavManager.Uri);
            var data = await sessionStorage.GetItemAsync<string>("Profile");
            promote.UserId = data;
            //res = await http.GetFromJsonAsync<ResponseModel>("api/signin/GetProfile?useremail=" + data);

            //await JS.InvokeAsync<string>("LoadDataTable", null);
        }

            protected async Task PromoteBusinessForm()
        {
            ResponseModel res = await http.GetFromJsonAsync<ResponseModel>("api/login?" + promote+"");
            if (!res.Status)
            {
                errorMessage = res.Message;
            }
            else
            {
                promote = JsonSerializer.Deserialize<PromoteBusiness>(JsonSerializer.Serialize(res.Result), new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                //await sessionStorage.SetItemAsync("Employee", employee);
                NavManager.NavigateTo("/Home");
            }
        }
    }
}
