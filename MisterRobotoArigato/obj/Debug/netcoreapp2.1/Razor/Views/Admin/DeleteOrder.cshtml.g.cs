#pragma checksum "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfd1fb9f51651087cbe7d8d86bbdf559ed64936d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_DeleteOrder), @"mvc.1.0.view", @"/Views/Admin/DeleteOrder.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/DeleteOrder.cshtml", typeof(AspNetCore.Views_Admin_DeleteOrder))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\_ViewImports.cshtml"
using MisterRobotoArigato;

#line default
#line hidden
#line 5 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\_ViewImports.cshtml"
using MisterRobotoArigato.Models;

#line default
#line hidden
#line 3 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\_ViewImports.cshtml"
using MisterRobotoArigato.Models.ViewModel;

#line default
#line hidden
#line 4 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfd1fb9f51651087cbe7d8d86bbdf559ed64936d", @"/Views/Admin/DeleteOrder.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a84f8cb23abf75c860110a2700ad5a34acd5ff9", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_DeleteOrder : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteOrderConfirmed", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-lg btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RecentOrders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
  
    ViewData["Title"] = "Orders";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(133, 553, true);
            WriteLiteral(@"
<div class=""py-5 text-center"">
    <h2>Delete Order</h2>
    <img class=""d-block mx-auto mb-4"" src=""http://worldartsme.com/images/delete-clipart-1.jpg""  alt=""delete icon"" width=""72"" height=""72""/>
</div>
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-4 order-md-2 mb-4"">
            <h4 class=""d-flex justify-content-between align-items-center mb-3"">
                <span class=""text-muted"">Your checkout bag</span>
                <span class=""badge badge-secondary badge-pill""><i class=""fas fa-shopping-bag""></i>  ");
            EndContext();
            BeginContext(687, 18, false);
#line 18 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                                                                                               Write(Model.TotalItemQty);

#line default
#line hidden
            EndContext();
            BeginContext(705, 72, true);
            WriteLiteral("</span>\r\n\r\n            </h4>\r\n            <ul class=\"list-group mb-3\">\r\n");
            EndContext();
#line 22 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                  
                    decimal orderTotal = 0;
                

#line default
#line hidden
            BeginContext(861, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 25 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                 foreach (var orderItem in Model.OrderItems)
                {
                    var totalItemPrice = orderItem.UnitPrice * orderItem.Quantity;
                    orderTotal += totalItemPrice;

#line default
#line hidden
            BeginContext(1077, 189, true);
            WriteLiteral("                    <li class=\"list-group-item d-flex justify-content-between lh-condensed\">\r\n                        <div class=\"float-left\">\r\n                            <h6 class=\"my-0\">");
            EndContext();
            BeginContext(1267, 21, false);
#line 31 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                                        Write(orderItem.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(1288, 71, true);
            WriteLiteral("</h6>\r\n                            <small class=\"text-muted\">Quantity: ");
            EndContext();
            BeginContext(1360, 18, false);
#line 32 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                                                           Write(orderItem.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1378, 70, true);
            WriteLiteral("</small>\r\n                        </div>\r\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1448, "\"", 1471, 1);
#line 34 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
WriteAttributeValue("", 1454, orderItem.ImgUrl, 1454, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1472, 73, true);
            WriteLiteral(" class=\"checkout-img\">\r\n                        <span class=\"text-muted\">");
            EndContext();
            BeginContext(1546, 14, false);
#line 35 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                                            Write(totalItemPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1560, 36, true);
            WriteLiteral("</span>\r\n                    </li>\r\n");
            EndContext();
#line 37 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                }

#line default
#line hidden
            BeginContext(1615, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 39 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                 if (Model.DiscountPercent != 0)
                {
                    decimal discountAmt = (Model.DiscountPercent / 100) * orderTotal;

#line default
#line hidden
            BeginContext(1773, 177, true);
            WriteLiteral("                    <li class=\"list-group-item d-flex justify-content-between bg-light\">\r\n                        <h6 class=\"my-0\">Subtotal</h6>\r\n                        <span>$");
            EndContext();
            BeginContext(1951, 14, false);
#line 44 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                          Write(Model.Subtotal);

#line default
#line hidden
            EndContext();
            BeginContext(1965, 275, true);
            WriteLiteral(@"</span>
                    </li>
                    <li class=""list-group-item d-flex justify-content-between bg-light"">
                        <div class=""text-success"">
                            <h6 class=""my-0"">Promo code</h6>
                            <small>");
            EndContext();
            BeginContext(2241, 18, false);
#line 49 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                              Write(Model.DiscountName);

#line default
#line hidden
            EndContext();
            BeginContext(2259, 95, true);
            WriteLiteral("</small>\r\n                        </div>\r\n                        <span class=\"text-success\">-$");
            EndContext();
            BeginContext(2355, 17, false);
#line 51 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                                                Write(Model.DiscountAmt);

#line default
#line hidden
            EndContext();
            BeginContext(2372, 36, true);
            WriteLiteral("</span>\r\n                    </li>\r\n");
            EndContext();
#line 53 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                }

#line default
#line hidden
            BeginContext(2427, 123, true);
            WriteLiteral("                <li class=\"list-group-item d-flex justify-content-between\">\r\n                    <span>Total (USD)</span>\r\n");
            EndContext();
            BeginContext(2574, 33, true);
            WriteLiteral("                        <strong>$");
            EndContext();
            BeginContext(2608, 11, false);
#line 57 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                            Write(Model.Total);

#line default
#line hidden
            EndContext();
            BeginContext(2619, 11, true);
            WriteLiteral("</strong>\r\n");
            EndContext();
            BeginContext(2653, 221, true);
            WriteLiteral("                </li>\r\n            </ul>\r\n        </div>\r\n        <div class=\"col-md-8 order-md-1\">\r\n            <div class=\"row\">\r\n                <div class=\"col-md-6 mb-3\">\r\n                    <h4 class=\"mb-3\">Order #");
            EndContext();
            BeginContext(2875, 8, false);
#line 65 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                                       Write(Model.ID);

#line default
#line hidden
            EndContext();
            BeginContext(2883, 86, true);
            WriteLiteral("</h4>\r\n                    <p>\r\n                        <div class=\"d-inline-block\">\r\n");
            EndContext();
#line 68 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                              
                                var user = await UserManager.FindByIdAsync(Model.UserID);

#line default
#line hidden
            BeginContext(3092, 59, true);
            WriteLiteral("                                <strong>Customer:</strong> ");
            EndContext();
            BeginContext(3152, 14, false);
#line 70 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                                                      Write(user.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(3168, 13, false);
#line 70 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                                                                      Write(user.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(3181, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(3220, 57, true);
            WriteLiteral("                            <strong>Order Date:</strong> ");
            EndContext();
            BeginContext(3278, 15, false);
#line 72 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                                                    Write(Model.OrderDate);

#line default
#line hidden
            EndContext();
            BeginContext(3293, 326, true);
            WriteLiteral(@"<br />
                        </div>
                    </p>
                </div>
            </div>
            <hr class=""mb-4"">
            <div class=""row"">
                <div class=""col-md-6 mb-3"">
                    <h4 class=""mb-3"">Shipping address</h4>
                    <p>
                        ");
            EndContext();
            BeginContext(3620, 23, false);
#line 82 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                   Write(Model.Address.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(3643, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3645, 22, false);
#line 82 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                                            Write(Model.Address.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(3667, 32, true);
            WriteLiteral("<br />\r\n                        ");
            EndContext();
            BeginContext(3700, 20, false);
#line 83 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                   Write(Model.Address.Street);

#line default
#line hidden
            EndContext();
            BeginContext(3720, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
#line 84 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                         if (Model.Address.Street2 != null)
                        {
                            

#line default
#line hidden
            BeginContext(3845, 21, false);
#line 86 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                       Write(Model.Address.Street2);

#line default
#line hidden
            EndContext();
            BeginContext(3866, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
#line 87 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                        }

#line default
#line hidden
            BeginContext(3901, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(3926, 18, false);
#line 88 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                   Write(Model.Address.City);

#line default
#line hidden
            EndContext();
            BeginContext(3944, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3946, 19, false);
#line 88 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                                       Write(Model.Address.State);

#line default
#line hidden
            EndContext();
            BeginContext(3965, 32, true);
            WriteLiteral("<br />\r\n                        ");
            EndContext();
            BeginContext(3998, 17, false);
#line 89 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                   Write(Model.Address.Zip);

#line default
#line hidden
            EndContext();
            BeginContext(4015, 32, true);
            WriteLiteral("<br />\r\n                        ");
            EndContext();
            BeginContext(4048, 21, false);
#line 90 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                   Write(Model.Address.Country);

#line default
#line hidden
            EndContext();
            BeginContext(4069, 179, true);
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n                <div class=\"col-md-6 mb-3\">\r\n                    <h4 class=\"mb-3\">Shipping Method</h4>\r\n                    <p>");
            EndContext();
            BeginContext(4249, 14, false);
#line 95 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
                  Write(Model.Shipping);

#line default
#line hidden
            EndContext();
            BeginContext(4263, 93, true);
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n            <hr class=\"mb-4\">\r\n            ");
            EndContext();
            BeginContext(4356, 254, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57f234b864a44f5da4abe9d78fda206a", async() => {
                BeginContext(4433, 18, true);
                WriteLiteral("\r\n                ");
                EndContext();
                BeginContext(4451, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "56f74dd0668c4436b7420aa7acbe8a82", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 100 "C:\Users\Geri\Source\Repos\Eris1allkanjari\E-Commerce\MisterRobotoArigato\Views\Admin\DeleteOrder.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4487, 116, true);
                WriteLiteral("\r\n                <input type=\"submit\" value=\"Delete Order\" class=\"btn btn-danger btn-lg btn-block\" />\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4610, 38, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n        ");
            EndContext();
            BeginContext(4648, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55982a2d23fe42ac89709e739e8c832b", async() => {
                BeginContext(4738, 19, true);
                WriteLiteral("Return to Order Log");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4761, 16, true);
            WriteLiteral("\r\n</div>\r\n<br />");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Order> Html { get; private set; }
    }
}
#pragma warning restore 1591
