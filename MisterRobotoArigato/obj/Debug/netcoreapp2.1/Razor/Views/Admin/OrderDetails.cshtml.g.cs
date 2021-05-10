#pragma checksum "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\OrderDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da108cb8d8ed5ad8d26e5df6fc6633c407990e17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_OrderDetails), @"mvc.1.0.view", @"/Views/Admin/OrderDetails.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/OrderDetails.cshtml", typeof(AspNetCore.Views_Admin_OrderDetails))]
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
#line 1 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\_ViewImports.cshtml"
using MisterRobotoArigato;

#line default
#line hidden
#line 5 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\_ViewImports.cshtml"
using MisterRobotoArigato.Models;

#line default
#line hidden
#line 3 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\_ViewImports.cshtml"
using MisterRobotoArigato.Models.ViewModel;

#line default
#line hidden
#line 4 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da108cb8d8ed5ad8d26e5df6fc6633c407990e17", @"/Views/Admin/OrderDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e8ae2ccbb7e94b73188ce3e6eb3a1d410ddbaed", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_OrderDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Order>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RecentOrders", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\OrderDetails.cshtml"
  
    ViewData["Title"] = "OrderDetails";
    Layout = "_Layout";


#line default
#line hidden
            BeginContext(84, 443, true);
            WriteLiteral(@"
<div class=""order container"">
    <div class=""py-5 text-center"">
        <h2>Order Details</h2>
    </div>
        <div class=""row"">
            <div class=""col-md-4 order-md-2 mb-4"">
                <h4 class=""d-flex justify-content-between align-items-center mb-3"">
                    <span class=""text-muted"">Your checkout bag</span>
                    <span class=""badge badge-secondary badge-pill""><i class=""fas fa-shopping-bag""></i>  ");
            EndContext();
            BeginContext(528, 18, false);
#line 17 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\OrderDetails.cshtml"
                                                                                                   Write(Model.TotalItemQty);

#line default
#line hidden
            EndContext();
            BeginContext(546, 76, true);
            WriteLiteral("</span>\n\n                </h4>\n                <ul class=\"list-group mb-3\">\n");
            EndContext();
#line 21 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\OrderDetails.cshtml"
                      
                        decimal orderTotal = 0;
                    

#line default
#line hidden
            BeginContext(715, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 24 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\OrderDetails.cshtml"
                     foreach (var orderItem in Model.OrderItems)
                    {
                        var totalItemPrice = orderItem.UnitPrice * orderItem.Quantity;
                        orderTotal += totalItemPrice;

#line default
#line hidden
            BeginContext(943, 199, true);
            WriteLiteral("                        <li class=\"list-group-item d-flex justify-content-between lh-condensed\">\n                            <div class=\"float-left\">\n                                <h6 class=\"my-0\">");
            EndContext();
            BeginContext(1143, 21, false);
#line 30 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\OrderDetails.cshtml"
                                            Write(orderItem.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(1164, 74, true);
            WriteLiteral("</h6>\n                                <small class=\"text-muted\">Quantity: ");
            EndContext();
            BeginContext(1239, 18, false);
#line 31 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\OrderDetails.cshtml"
                                                               Write(orderItem.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1257, 76, true);
            WriteLiteral("</small>\n                            </div>\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1333, "\"", 1356, 1);
#line 33 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\OrderDetails.cshtml"
WriteAttributeValue("", 1339, orderItem.ImgUrl, 1339, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1357, 76, true);
            WriteLiteral(" class=\"checkout-img\">\n                            <span class=\"text-muted\">");
            EndContext();
            BeginContext(1434, 14, false);
#line 34 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\OrderDetails.cshtml"
                                                Write(totalItemPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1448, 38, true);
            WriteLiteral("</span>\n                        </li>\n");
            EndContext();
#line 36 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\OrderDetails.cshtml"
                    }

#line default
#line hidden
            BeginContext(1508, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 38 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\OrderDetails.cshtml"
                     if (Model.DiscountPercent != 0)
                    {
                        decimal discountAmt = (Model.DiscountPercent / 100) * orderTotal;

#line default
#line hidden
            BeginContext(1674, 187, true);
            WriteLiteral("                        <li class=\"list-group-item d-flex justify-content-between bg-light\">\n                            <h6 class=\"my-0\">Subtotal</h6>\n                            <span>$");
            EndContext();
            BeginContext(1862, 14, false);
#line 43 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\OrderDetails.cshtml"
                              Write(Model.Subtotal);

#line default
#line hidden
            EndContext();
            BeginContext(1876, 290, true);
            WriteLiteral(@"</span>
                        </li>
                        <li class=""list-group-item d-flex justify-content-between bg-light"">
                            <div class=""text-success"">
                                <h6 class=""my-0"">Promo code</h6>
                                <small>");
            EndContext();
            BeginContext(2167, 18, false);
#line 48 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\OrderDetails.cshtml"
                                  Write(Model.DiscountName);

#line default
#line hidden
            EndContext();
            BeginContext(2185, 101, true);
            WriteLiteral("</small>\n                            </div>\n                            <span class=\"text-success\">-$");
            EndContext();
            BeginContext(2287, 17, false);
#line 50 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\OrderDetails.cshtml"
                                                    Write(Model.DiscountAmt);

#line default
#line hidden
            EndContext();
            BeginContext(2304, 38, true);
            WriteLiteral("</span>\n                        </li>\n");
            EndContext();
#line 52 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\OrderDetails.cshtml"
                    }

#line default
#line hidden
            BeginContext(2364, 129, true);
            WriteLiteral("                    <li class=\"list-group-item d-flex justify-content-between\">\n                        <span>Total (USD)</span>\n");
            EndContext();
            BeginContext(2520, 37, true);
            WriteLiteral("                            <strong>$");
            EndContext();
            BeginContext(2558, 11, false);
#line 56 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\OrderDetails.cshtml"
                                Write(Model.Total);

#line default
#line hidden
            EndContext();
            BeginContext(2569, 10, true);
            WriteLiteral("</strong>\n");
            EndContext();
            BeginContext(2605, 243, true);
            WriteLiteral("                    </li>\n                </ul>\n            </div>\n            <div class=\"col-md-8 order-md-1\">\n                <div class=\"row\">\n                    <div class=\"col-md-6 mb-3\">\n                        <h4 class=\"mb-3\">Order #");
            EndContext();
            BeginContext(2849, 8, false);
#line 64 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\OrderDetails.cshtml"
                                           Write(Model.ID);

#line default
#line hidden
            EndContext();
            BeginContext(2857, 91, true);
            WriteLiteral("</h4>\n                        <p>\n                            <div class=\"d-inline-block\">\n");
            EndContext();
#line 67 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\OrderDetails.cshtml"
                                  
                                    var user = await UserManager.FindByEmailAsync(User.Identity.Name);
                                    string fullName = $"{user.FirstName} {user.LastName}";

#line default
#line hidden
            BeginContext(3177, 63, true);
            WriteLiteral("                                    <strong>Customer:</strong> ");
            EndContext();
            BeginContext(3241, 8, false);
#line 70 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\OrderDetails.cshtml"
                                                          Write(fullName);

#line default
#line hidden
            EndContext();
            BeginContext(3249, 7, true);
            WriteLiteral("<br />\n");
            EndContext();
            BeginContext(3290, 61, true);
            WriteLiteral("                                <strong>Order Date:</strong> ");
            EndContext();
            BeginContext(3352, 15, false);
#line 72 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\OrderDetails.cshtml"
                                                        Write(Model.OrderDate);

#line default
#line hidden
            EndContext();
            BeginContext(3367, 356, true);
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
            BeginContext(3724, 23, false);
#line 82 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\OrderDetails.cshtml"
                       Write(Model.Address.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(3747, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3749, 22, false);
#line 82 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\OrderDetails.cshtml"
                                                Write(Model.Address.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(3771, 35, true);
            WriteLiteral("<br />\n                            ");
            EndContext();
            BeginContext(3807, 20, false);
#line 83 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\OrderDetails.cshtml"
                       Write(Model.Address.Street);

#line default
#line hidden
            EndContext();
            BeginContext(3827, 7, true);
            WriteLiteral("<br />\n");
            EndContext();
#line 84 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\OrderDetails.cshtml"
                             if (Model.Address.Street2 != null)
                            {
                                

#line default
#line hidden
            BeginContext(3961, 21, false);
#line 86 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\OrderDetails.cshtml"
                           Write(Model.Address.Street2);

#line default
#line hidden
            EndContext();
            BeginContext(3982, 7, true);
            WriteLiteral("<br />\n");
            EndContext();
#line 87 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\OrderDetails.cshtml"
                            }

#line default
#line hidden
            BeginContext(4019, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(4048, 18, false);
#line 88 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\OrderDetails.cshtml"
                       Write(Model.Address.City);

#line default
#line hidden
            EndContext();
            BeginContext(4066, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(4068, 19, false);
#line 88 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\OrderDetails.cshtml"
                                           Write(Model.Address.State);

#line default
#line hidden
            EndContext();
            BeginContext(4087, 35, true);
            WriteLiteral("<br />\n                            ");
            EndContext();
            BeginContext(4123, 17, false);
#line 89 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\OrderDetails.cshtml"
                       Write(Model.Address.Zip);

#line default
#line hidden
            EndContext();
            BeginContext(4140, 35, true);
            WriteLiteral("<br />\n                            ");
            EndContext();
            BeginContext(4176, 21, false);
#line 90 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\OrderDetails.cshtml"
                       Write(Model.Address.Country);

#line default
#line hidden
            EndContext();
            BeginContext(4197, 194, true);
            WriteLiteral("\n                        </p>\n                    </div>\n                    <div class=\"col-md-6 mb-3\">\n                        <h4 class=\"mb-3\">Shipping Method</h4>\n                        <p>");
            EndContext();
            BeginContext(4392, 14, false);
#line 95 "C:\Users\ASUS\Desktop\Shkolla\e_commerce\projekt\E-Commerce-master\MisterRobotoArigato\Views\Admin\OrderDetails.cshtml"
                      Write(Model.Shipping);

#line default
#line hidden
            EndContext();
            BeginContext(4406, 105, true);
            WriteLiteral("</p>\n                    </div>\n                </div>\n                <hr class=\"mb-4\">\n                ");
            EndContext();
            BeginContext(4511, 188, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed72eb985a1b4204aa2ac5b17a09ca48", async() => {
                BeginContext(4566, 126, true);
                WriteLiteral("\n                    <button class=\"btn btn-info btn-lg btn-block\" type=\"submit\">Return to Order Log</button>\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4699, 46, true);
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
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
