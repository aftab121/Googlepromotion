#pragma checksum "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1082e212c9bee2499a172266c017a1a03bd139a0"
// <auto-generated/>
#pragma warning disable 1591
namespace Googlepromotion.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\_Imports.razor"
using Googlepromotion.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\_Imports.razor"
using Googlepromotion.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Login.razor"
using Microsoft.AspNetCore.WebUtilities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(EmptyLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
#nullable restore
#line 5 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Login.razor"
__builder.AddContent(1, emaildiv);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.AddMarkupContent(3, "<style>\r\n    html {\r\n        height: 100%\r\n    }\r\n\r\n    ::-moz-selection {\r\n        background: #fe57a1;\r\n        color: #fff;\r\n        text-shadow: none;\r\n    }\r\n\r\n    ::selection {\r\n        background: #fe57a1;\r\n        color: #fff;\r\n        text-shadow: none;\r\n    }\r\n\r\n    body {\r\n        background-image: radial-gradient( cover, rgba(92,100,111,1) 0%,rgba(31,35,40,1) 100%), url(\'http://i.minus.com/io97fW9I0NqJq.png\')\r\n    }\r\n\r\n    .login {\r\n        background: #eceeee;\r\n        border: 1px solid #42464b;\r\n        border-radius: 6px;\r\n        height: 300px;\r\n        margin: 20px auto 0;\r\n        width: 298px;\r\n        margin-top: 150px;\r\n    }\r\n\r\n        .login h1 {\r\n            background-image: linear-gradient(top, #f1f3f3, #d4dae0);\r\n            border-bottom: 1px solid #a6abaf;\r\n            border-radius: 6px 6px 0 0;\r\n            box-sizing: border-box;\r\n            color: #727678;\r\n            display: block;\r\n            height: 43px;\r\n            font: 600 14px/1 \'Open Sans\', sans-serif;\r\n            padding-top: 14px;\r\n            margin: 0;\r\n            text-align: center;\r\n            text-shadow: 0 -1px 0 rgba(0,0,0,0.2), 0 1px 0 #fff;\r\n        }\r\n\r\n    input[type=\"password\"], input[type=\"text\"] {\r\n        background: url(\'http://i.minus.com/ibhqW9Buanohx2.png\') center left no-repeat, linear-gradient(top, #d6d7d7, #dee0e0);\r\n        border: 1px solid #a1a3a3;\r\n        border-radius: 4px;\r\n        box-shadow: 0 1px #fff;\r\n        box-sizing: border-box;\r\n        color: #696969;\r\n        height: 39px;\r\n        margin: 31px 0 0 29px;\r\n        padding-left: 37px;\r\n        transition: box-shadow 0.3s;\r\n        width: 240px;\r\n    }\r\n\r\n        input[type=\"password\"]:focus, input[type=\"text\"]:focus {\r\n            box-shadow: 0 0 4px 1px rgba(55, 166, 155, 0.3);\r\n            outline: 0;\r\n        }\r\n\r\n    .show-password {\r\n        display: block;\r\n        height: 16px;\r\n        margin: 26px 0 0 28px;\r\n        width: 87px;\r\n    }\r\n\r\n    input[type=\"checkbox\"] {\r\n        cursor: pointer;\r\n        height: 16px;\r\n        opacity: 0;\r\n        position: relative;\r\n        width: 64px;\r\n    }\r\n\r\n        input[type=\"checkbox\"]:checked {\r\n            left: 29px;\r\n            width: 58px;\r\n        }\r\n\r\n    .toggle {\r\n        background: url(http://i.minus.com/ibitS19pe8PVX6.png) no-repeat;\r\n        display: block;\r\n        height: 16px;\r\n        margin-top: -20px;\r\n        width: 87px;\r\n        z-index: -1;\r\n    }\r\n\r\n    input[type=\"checkbox\"]:checked + .toggle {\r\n        background-position: 0 -16px\r\n    }\r\n\r\n    .forgot {\r\n        color: #7f7f7f;\r\n        display: inline-block;\r\n        float: right;\r\n        font: 12px/1 sans-serif;\r\n        left: -19px;\r\n        position: relative;\r\n        text-decoration: none;\r\n        top: 5px;\r\n        transition: color .4s;\r\n    }\r\n\r\n        .forgot:hover {\r\n            color: #3b3b3b\r\n        }\r\n\r\n    button[type=\"submit\"] {\r\n        width: 240px;\r\n        height: 35px;\r\n        display: block;\r\n        font-family: Arial, \"Helvetica\", sans-serif;\r\n        font-size: 16px;\r\n        font-weight: bold;\r\n        color: #fff;\r\n        text-decoration: none;\r\n        text-transform: uppercase;\r\n        text-align: center;\r\n        text-shadow: 1px 1px 0px #b34768;\r\n        padding-top: 6px;\r\n        margin: 29px 0 0 29px;\r\n        position: relative;\r\n        cursor: pointer;\r\n        border: none;\r\n        background-color: #b34768;\r\n        background-image: linear-gradient(top,#3db0a6,#3111);\r\n        border-top-left-radius: 5px;\r\n        border-top-right-radius: 5px;\r\n        border-bottom-right-radius: 5px;\r\n        border-bottom-left-radius: 5px;\r\n        box-shadow: inset 0px 1px 0px #2ab7ec, 0px 5px 0px 0px #497a78, 0px 10px 5px #999;\r\n    }\r\n\r\n    .shadow {\r\n        background: #000;\r\n        border-radius: 12px 12px 4px 4px;\r\n        box-shadow: 0 0 20px 10px #000;\r\n        height: 12px;\r\n        margin: 30px auto;\r\n        opacity: 0.2;\r\n        width: 270px;\r\n    }\r\n\r\n\r\n    input[type=\"submit\"]:active {\r\n        top: 3px;\r\n        box-shadow: inset 0px 1px 0px #2ab7ec, 0px 2px 0px 0px #31524d, 0px 5px 3px #999;\r\n    }\r\n\r\n    input[type=\"button\"] {\r\n        width: 240px;\r\n        height: 35px;\r\n        display: block;\r\n        font-family: Arial, \"Helvetica\", sans-serif;\r\n        font-size: 16px;\r\n        font-weight: bold;\r\n        color: #fff;\r\n        text-decoration: none;\r\n        text-transform: uppercase;\r\n        text-align: center;\r\n        text-shadow: 1px 1px 0px #37a69b;\r\n        padding-top: 6px;\r\n        margin: 29px 0 0 29px;\r\n        position: relative;\r\n        cursor: pointer;\r\n        border: none;\r\n        background-color: #37a69b;\r\n        background-image: linear-gradient(top,#3db0a6,#3111);\r\n        border-top-left-radius: 5px;\r\n        border-top-right-radius: 5px;\r\n        border-bottom-right-radius: 5px;\r\n        border-bottom-left-radius: 5px;\r\n        box-shadow: inset 0px 1px 0px #2ab7ec, 0px 5px 0px 0px #497a78, 0px 10px 5px #999;\r\n    }\r\n</style>\r\n");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "login");
            __builder.AddMarkupContent(6, "\r\n    <input type=\"text\" placeholder=\"Username\" id=\"username\">\r\n    <input type=\"password\" placeholder=\"password\" id=\"password\">\r\n    ");
            __builder.AddMarkupContent(7, "<a href=\"#\" class=\"forgot\">forgot password?</a>\r\n    <input type=\"button\" value=\"Login\">\r\n    ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "button");
            __builder.AddAttribute(10, "value", "Login With Google ");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 195 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Login.razor"
                                                              googleButton_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 198 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Login.razor"
       
    private string emaildiv;
    protected override void OnInitialized()
    {
        // variable = "hello world";
        var code = "";
        var uri = NavManager.ToAbsoluteUri(NavManager.Uri);
        if (QueryHelpers.ParseQuery(uri.Query).TryGetValue("code", out var param))
        {
            code = param;

        }
        if (code != null && code != "")
        {
            var data = "hghgh";
        }

    }
    public void googleButton_Click()
    {
        string clientId = "246162259773-vn416ss3gi6h8j444ch8gsllao8v45m9.apps.googleusercontent.com";
        string redirectUrl = "https://localhost:44320/Index";
        //  NavManager.NavigateTo("https://accounts.google.com/o/oauth2/auth?redirect_uri=" + redirectUrl + "&response_type=code&client_id=" + clientId + "&scope=https://www.google.com/m8/feeds/&approval_prompt=force&access_type=offline");

         string url = "https://accounts.google.com/o/oauth2/auth?scope=https://www.google.com/m8/feeds/+https://www.googleapis.com/auth/userinfo.email+https://www.googleapis.com/auth/userinfo.profile&redirect_uri=" + redirectUrl + "&response_type=code&client_id=" + clientId + "";
        //string url = "https://accounts.google.com/o/oauth2/auth?scope=https://www.google.com/m8/feeds/  https://www.googleapis.com/auth/userinfo.email  https://www.googleapis.com/auth/userinfo.profile&redirect_uri=" + redirectUrl + "&response_type=code&client_id=" + clientId + "";

        NavManager.NavigateTo(url);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
