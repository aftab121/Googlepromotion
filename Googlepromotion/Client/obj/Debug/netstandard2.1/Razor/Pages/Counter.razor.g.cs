#pragma checksum "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5456520839664fbbeb726a4af0946602a9d68f5c"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Counter</h1>\r\n\r\n");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Current count: ");
#nullable restore
#line 5 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Counter.razor"
__builder.AddContent(3, currentCount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(8, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Counter.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
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
