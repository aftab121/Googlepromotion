#pragma checksum "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Promote_Business.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5beebf55d0ba3d009a07861d22e7d396bcc876e1"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Promote_Business")]
    public partial class Promote_Business : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Promote_Business</h3>\r\n");
            __builder.OpenElement(1, "section");
            __builder.AddAttribute(2, "class", "wizard-section");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row no-gutters");
            __builder.AddMarkupContent(6, "\r\n\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-lg-6 col-md-6");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "form-wizard");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(13);
            __builder.AddAttribute(14, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Promote_Business.razor"
                                  promote

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Promote_Business.razor"
                                                           PromoteBusinessForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "class", "form-signin");
            __builder.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(18, "\r\n\r\n                    ");
                __builder2.OpenElement(19, "fieldset");
                __builder2.AddAttribute(20, "class", "wizard-fieldset show");
                __builder2.AddMarkupContent(21, "\r\n                        ");
                __builder2.AddMarkupContent(22, "<h5>Promote Business</h5>");
                __builder2.OpenElement(23, "p");
#nullable restore
#line 11 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Promote_Business.razor"
__builder2.AddContent(24, promote.UserId);

#line default
#line hidden
#nullable disable
                __builder2.AddContent(25, "\"");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(26, "\r\n\r\n                        ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "form-group");
                __builder2.AddMarkupContent(29, "\r\n                            ");
                __builder2.OpenElement(30, "input");
                __builder2.AddAttribute(31, "type", "text");
                __builder2.AddAttribute(32, "class", "form-control wizard-required");
                __builder2.AddAttribute(33, "id", "Name");
                __builder2.AddAttribute(34, "placeholder", "Name*");
                __builder2.AddAttribute(35, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Promote_Business.razor"
                                                                                                                               promote.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => promote.Name = __value, promote.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n\r\n                            <div class=\"wizard-form-error\"></div>\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n                        ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group");
                __builder2.AddMarkupContent(41, "\r\n                            ");
                __builder2.OpenElement(42, "input");
                __builder2.AddAttribute(43, "type", "file");
                __builder2.AddAttribute(44, "class", "form-control wizard-required");
                __builder2.AddAttribute(45, "id", "Logo");
                __builder2.AddAttribute(46, "placeholder", "");
                __builder2.AddAttribute(47, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Promote_Business.razor"
                                                                                                                          promote.Logo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => promote.Logo = __value, promote.Logo));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "Logo*\r\n                            <div class=\"wizard-form-error\"></div>\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                        ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "form-group");
                __builder2.AddMarkupContent(53, "\r\n                            ");
                __builder2.OpenElement(54, "input");
                __builder2.AddAttribute(55, "type", "text");
                __builder2.AddAttribute(56, "class", "form-control wizard-required");
                __builder2.AddAttribute(57, "id", "Link");
                __builder2.AddAttribute(58, "placeholder", "Link*");
                __builder2.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Promote_Business.razor"
                                                                                                                               promote.Website_Link

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => promote.Website_Link = __value, promote.Website_Link));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(61, "\r\n                            <div class=\"wizard-form-error\"></div>\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n\r\n                        ");
                __builder2.AddMarkupContent(63, "<div class=\"form-group clearfix\">\r\n                            <input type=\"submit\" value=\"Blast\" class=\"form-control\">\r\n                        </div>\r\n                        ");
                __builder2.OpenElement(64, "span");
                __builder2.AddAttribute(65, "class", " field-validation-error");
                __builder2.AddMarkupContent(66, "\r\n                            ");
                __builder2.OpenElement(67, "span");
#nullable restore
#line 31 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Promote_Business.razor"
__builder2.AddContent(68, errorMessage);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(71, "\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(72, ">\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
