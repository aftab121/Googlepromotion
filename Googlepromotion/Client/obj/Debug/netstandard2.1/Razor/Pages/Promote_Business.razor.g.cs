#pragma checksum "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Promote_Business.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "376438205b4262bcb7ce288442ff5ed7432c5354"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "cl-sm-12");
            __builder.AddMarkupContent(2, "\r\n        <div class=\"cl-sm-2\"></div>\r\n        ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "cl-sm-8");
            __builder.AddMarkupContent(5, "\r\n            ");
            __builder.OpenElement(6, "section");
            __builder.AddAttribute(7, "class", "wizard-section");
            __builder.AddMarkupContent(8, "\r\n                ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row no-gutters");
            __builder.AddMarkupContent(11, "\r\n\r\n                    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-lg-6 col-md-6");
            __builder.AddMarkupContent(14, "\r\n                        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-wizard");
            __builder.AddMarkupContent(17, "\r\n                            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(18);
            __builder.AddAttribute(19, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Promote_Business.razor"
                                              promote

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Promote_Business.razor"
                                                                       PromoteBusinessForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(21, "class", "form-signin");
            __builder.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(23, "\r\n\r\n                                ");
                __builder2.OpenElement(24, "fieldset");
                __builder2.AddAttribute(25, "class", "wizard-fieldset show");
                __builder2.AddMarkupContent(26, "\r\n                                    ");
                __builder2.AddMarkupContent(27, "<h5>Promote Business</h5>\r\n\r\n                                    ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "form-group");
                __builder2.AddMarkupContent(30, "\r\n                                        ");
                __builder2.OpenElement(31, "input");
                __builder2.AddAttribute(32, "type", "text");
                __builder2.AddAttribute(33, "class", "form-control wizard-required");
                __builder2.AddAttribute(34, "id", "UserId");
                __builder2.AddAttribute(35, "readonly", true);
                __builder2.AddAttribute(36, "placeholder", "*");
                __builder2.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 16 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Promote_Business.razor"
                                                                                                                                                  promote.UserId

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => promote.UserId = __value, promote.UserId));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(39, "\r\n\r\n                                        <div class=\"wizard-form-error\"></div>\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                                    ");
                __builder2.OpenElement(41, "div");
                __builder2.AddAttribute(42, "class", "form-group");
                __builder2.AddMarkupContent(43, "\r\n                                        ");
                __builder2.OpenElement(44, "input");
                __builder2.AddAttribute(45, "type", "text");
                __builder2.AddAttribute(46, "class", "form-control wizard-required");
                __builder2.AddAttribute(47, "id", "Name");
                __builder2.AddAttribute(48, "placeholder", "Name*");
                __builder2.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Promote_Business.razor"
                                                                                                                                           promote.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => promote.Name = __value, promote.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(51, "\r\n\r\n                                        <div class=\"wizard-form-error\"></div>\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n                                    ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "form-group");
                __builder2.AddMarkupContent(55, "\r\n                                        ");
                __builder2.OpenElement(56, "input");
                __builder2.AddAttribute(57, "type", "file");
                __builder2.AddAttribute(58, "class", "form-control wizard-required");
                __builder2.AddAttribute(59, "id", "Logo");
                __builder2.AddAttribute(60, "placeholder", "");
                __builder2.AddAttribute(61, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Promote_Business.razor"
                                                                                                                                      promote.Logo

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => promote.Logo = __value, promote.Logo));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "Logo*\r\n                                        <div class=\"wizard-form-error\"></div>\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                                    ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "form-group");
                __builder2.AddMarkupContent(67, "\r\n                                        ");
                __builder2.OpenElement(68, "input");
                __builder2.AddAttribute(69, "type", "text");
                __builder2.AddAttribute(70, "class", "form-control wizard-required");
                __builder2.AddAttribute(71, "id", "Link");
                __builder2.AddAttribute(72, "placeholder", "Link*");
                __builder2.AddAttribute(73, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 30 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Promote_Business.razor"
                                                                                                                                           promote.Website_Link

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(74, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => promote.Website_Link = __value, promote.Website_Link));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                                        <div class=\"wizard-form-error\"></div>\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n\r\n                                    ");
                __builder2.AddMarkupContent(77, @"<div class=""form-group clearfix"">
                                        <input type=""submit"" value=""Blast"" class=""form-control"" style=""background-color: #0c1238;color:white;font-weight:bold "">
                                    </div>
                                    ");
                __builder2.OpenElement(78, "span");
                __builder2.AddAttribute(79, "class", " field-validation-error");
                __builder2.AddMarkupContent(80, "\r\n                                        ");
                __builder2.OpenElement(81, "span");
#nullable restore
#line 38 "C:\Users\upkar\Desktop\Current Google Promotion\Googlepromotion Current\Googlepromotion\Googlepromotion\Client\Pages\Promote_Business.razor"
__builder2.AddContent(82, errorMessage);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(84, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(85, "\r\n                            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(86, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n        <div class=\"cl-sm-2\"></div>\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
    }
}
#pragma warning restore 1591
