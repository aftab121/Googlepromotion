﻿using Google.Contacts;
using Google.GData.Client;
using Google.GData.Contacts;
using Google.GData.Extensions;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.WebUtilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;
using Googlepromotion.Shared;
using Googlepromotion.Shared.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Net.NetworkInformation;
using Google.Apis.Auth.OAuth2;


namespace Googlepromotion.Client.Pages
{
    public partial class  Index:ComponentBase
    {
        HttpClient http = new HttpClient();
       // ResponseModel res = new ResponseModel();
        private string emaildiv;
        private string code;
        public string client;
        public string scret;
        public string variable;
        User user = new User();
        //protected override void OnInitialized()
        //{
        //    var data = sessionStorage.GetItemAsync<string>("Data");
        //    var code = "";
        //    var uri = NavManager.ToAbsoluteUri(NavManager.Uri);
        //    if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("code", out var param))
        //    {
        //        code = param;

        //    }
        // // await GetAccessToken(code);
        //}

        protected override async Task OnInitializedAsync()
        {

            http.BaseAddress = new Uri(NavManager.Uri);
            var url = NavManager.ToAbsoluteUri(NavManager.Uri);
            var data = await sessionStorage.GetItemAsync<string>("Profile");
            var res = data;
          
        }
        public async Task GetAccessToken()
        {
            var code = "";
            var uri = NavManager.ToAbsoluteUri(NavManager.Uri);
            if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("code", out var param))
            {
                code = param;
                //emaildiv = "sadfasd";
                //emaildiv = param;
            }
          await LoadOrders(code);
        }

        private ResponseModel res;
            


        private async Task LoadOrders(string code)
        {
            http.BaseAddress = new Uri(NavManager.Uri);
            var url = NavManager.ToAbsoluteUri(NavManager.Uri);
            res = await http.GetFromJsonAsync<ResponseModel>("api/signin/get?code=" + code);
            if (res.Status = true)
            {

                await sessionStorage.SetItemAsync("Profile", res.Email);
                //user = System.Text.Json.JsonSerializer.Deserialize<User>(JsonSerializer.Serialize(res.Result), new JsonSerializerOptions
                //{
                //    PropertyNameCaseInsensitive = true
                //});
            }
            NavManager.NavigateTo("/Profile");

        }
    }
}