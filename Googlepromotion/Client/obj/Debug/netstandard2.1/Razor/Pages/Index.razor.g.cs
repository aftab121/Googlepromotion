#pragma checksum "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8a3efaf3d9be301e7253e00a7fdf633f8559458"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Index")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Index.razor"
__builder.AddContent(0, (MarkupString)loader);

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "\r\n");
            __builder.AddMarkupContent(2, @"<style>
    .row-cols-3 {
        height: 150px;
        width: 300px;
        background-color: #6c1c81;
        color: white;
        font-family: 'Gill Sans', 'Gill Sans MT', Calibri, 'Trebuchet MS', sans-serif;
        font-weight: bold;
        font-size: 25px;
        text-align: center;
        margin: 10px 10px 10px 10px;
        line-height: 6;
    }
</style>
");
#nullable restore
#line 19 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Index.razor"
 if (User == null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Index.razor"
     if (errormsg != "")
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "        ");
            __builder.OpenElement(4, "h1");
            __builder.AddAttribute(5, "style", "color:red");
#nullable restore
#line 23 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Index.razor"
__builder.AddContent(6, errormsg);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "input");
            __builder.AddAttribute(9, "type", "button");
            __builder.AddAttribute(10, "value", "Try Again");
            __builder.AddAttribute(11, "style", "background-color: #0c1238;color:white;font-weight:bold ");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Index.razor"
                                                                                                                     googleButton_Click

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 25 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Index.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "        ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Index.razor"
                          GetAccessToken

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "style", "background-color: #0c1238;color:white;font-weight:bold ");
            __builder.AddContent(18, "Get Gmail Contact");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 29 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Index.razor"
     
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "    ");
            __builder.AddMarkupContent(21, @"<div class=""row"">
        <a href=""Profile""><div class=""row-cols-3"">Profile</div></a>
        <a href=""Promote_Business""><div class=""row-cols-3"">Business Promote</div></a>
        <a href=""https://accounts.google.com/Logout""><div class=""row-cols-3"">Logout</div></a>
    </div>
");
#nullable restore
#line 38 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Index.razor"
  
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
