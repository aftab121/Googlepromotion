using Googlepromotion.Shared.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;


namespace Googlepromotion.Client.Pages
{
public partial class UserProfile:ComponentBase
{
        HttpClient http = new HttpClient();
        ResponseModel res = new ResponseModel();
        User[] user;
        protected override async Task OnInitializedAsync()
        {

            http.BaseAddress = new Uri(NavManager.Uri);
            var url = NavManager.ToAbsoluteUri(NavManager.Uri);
            var data = await sessionStorage.GetItemAsync<string>("Profile");
           res = await http.GetFromJsonAsync<ResponseModel>("api/signin/GetProfile?useremail="+data);
            if (!res.Status)
            {
                //errorMessage = res.Message;
               
            }
            else
            {
                user = JsonSerializer.Deserialize<User[]>(JsonSerializer.Serialize(res.Result), new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
                await sessionStorage.SetItemAsync("UserName", user[0].Profile);
            }
            //await JS.InvokeAsync<string>("LoadDataTable", null);
        }
    }
}
