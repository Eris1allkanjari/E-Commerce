#pragma checksum "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\OrderDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b403e18ad163a31f9005bca8da5b56ca36800b09"
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
#line 1 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\_ViewImports.cshtml"
using Ecommerce;

#line default
#line hidden
#line 5 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\_ViewImports.cshtml"
using Ecommerce.Models;

#line default
#line hidden
#line 3 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\_ViewImports.cshtml"
using Ecommerce.Models.ViewModel;

#line default
#line hidden
#line 4 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b403e18ad163a31f9005bca8da5b56ca36800b09", @"/Views/Admin/OrderDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4659f17248f0e019fe19d081499f101d0de08d56", @"/Views/_ViewImports.cshtml")]
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
            BeginContext(14, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\OrderDetails.cshtml"
  
    ViewData["Title"] = "OrderDetails";
    Layout = "_Layout";


#line default
#line hidden
            BeginContext(91, 452, true);
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
            BeginContext(544, 18, false);
#line 17 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\OrderDetails.cshtml"
                                                                                                   Write(Model.TotalItemQty);

#line default
#line hidden
            EndContext();
            BeginContext(562, 80, true);
            WriteLiteral("</span>\r\n\r\n                </h4>\r\n                <ul class=\"list-group mb-3\">\r\n");
            EndContext();
#line 21 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\OrderDetails.cshtml"
                      
                        decimal orderTotal = 0;
                    

#line default
#line hidden
            BeginContext(738, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 24 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\OrderDetails.cshtml"
                     foreach (var orderItem in Model.OrderItems)
                    {
                        var totalItemPrice = orderItem.UnitPrice * orderItem.Quantity;
                        orderTotal += totalItemPrice;

#line default
#line hidden
            BeginContext(970, 201, true);
            WriteLiteral("                        <li class=\"list-group-item d-flex justify-content-between lh-condensed\">\r\n                            <div class=\"float-left\">\r\n                                <h6 class=\"my-0\">");
            EndContext();
            BeginContext(1172, 21, false);
#line 30 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\OrderDetails.cshtml"
                                            Write(orderItem.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(1193, 75, true);
            WriteLiteral("</h6>\r\n                                <small class=\"text-muted\">Quantity: ");
            EndContext();
            BeginContext(1269, 18, false);
#line 31 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\OrderDetails.cshtml"
                                                               Write(orderItem.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1287, 78, true);
            WriteLiteral("</small>\r\n                            </div>\r\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1365, "\"", 1388, 1);
#line 33 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\OrderDetails.cshtml"
WriteAttributeValue("", 1371, orderItem.ImgUrl, 1371, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1389, 77, true);
            WriteLiteral(" class=\"checkout-img\">\r\n                            <span class=\"text-muted\">");
            EndContext();
            BeginContext(1467, 14, false);
#line 34 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\OrderDetails.cshtml"
                                                Write(totalItemPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1481, 40, true);
            WriteLiteral("</span>\r\n                        </li>\r\n");
            EndContext();
#line 36 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\OrderDetails.cshtml"
                    }

#line default
#line hidden
            BeginContext(1544, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 38 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\OrderDetails.cshtml"
                     if (Model.DiscountPercent != 0)
                    {
                        decimal discountAmt = (Model.DiscountPercent / 100) * orderTotal;

#line default
#line hidden
            BeginContext(1714, 189, true);
            WriteLiteral("                        <li class=\"list-group-item d-flex justify-content-between bg-light\">\r\n                            <h6 class=\"my-0\">Subtotal</h6>\r\n                            <span>$");
            EndContext();
            BeginContext(1904, 14, false);
#line 43 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\OrderDetails.cshtml"
                              Write(Model.Subtotal);

#line default
#line hidden
            EndContext();
            BeginContext(1918, 295, true);
            WriteLiteral(@"</span>
                        </li>
                        <li class=""list-group-item d-flex justify-content-between bg-light"">
                            <div class=""text-success"">
                                <h6 class=""my-0"">Promo code</h6>
                                <small>");
            EndContext();
            BeginContext(2214, 18, false);
#line 48 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\OrderDetails.cshtml"
                                  Write(Model.DiscountName);

#line default
#line hidden
            EndContext();
            BeginContext(2232, 103, true);
            WriteLiteral("</small>\r\n                            </div>\r\n                            <span class=\"text-success\">-$");
            EndContext();
            BeginContext(2336, 17, false);
#line 50 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\OrderDetails.cshtml"
                                                    Write(Model.DiscountAmt);

#line default
#line hidden
            EndContext();
            BeginContext(2353, 40, true);
            WriteLiteral("</span>\r\n                        </li>\r\n");
            EndContext();
#line 52 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\OrderDetails.cshtml"
                    }

#line default
#line hidden
            BeginContext(2416, 131, true);
            WriteLiteral("                    <li class=\"list-group-item d-flex justify-content-between\">\r\n                        <span>Total (USD)</span>\r\n");
            EndContext();
            BeginContext(2575, 37, true);
            WriteLiteral("                            <strong>$");
            EndContext();
            BeginContext(2613, 11, false);
#line 56 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\OrderDetails.cshtml"
                                Write(Model.Total);

#line default
#line hidden
            EndContext();
            BeginContext(2624, 11, true);
            WriteLiteral("</strong>\r\n");
            EndContext();
            BeginContext(2662, 249, true);
            WriteLiteral("                    </li>\r\n                </ul>\r\n            </div>\r\n            <div class=\"col-md-8 order-md-1\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-6 mb-3\">\r\n                        <h4 class=\"mb-3\">Order #");
            EndContext();
            BeginContext(2912, 8, false);
#line 64 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\OrderDetails.cshtml"
                                           Write(Model.ID);

#line default
#line hidden
            EndContext();
            BeginContext(2920, 94, true);
            WriteLiteral("</h4>\r\n                        <p>\r\n                            <div class=\"d-inline-block\">\r\n");
            EndContext();
#line 67 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\OrderDetails.cshtml"
                                  
                                    var user = await UserManager.FindByEmailAsync(User.Identity.Name);
                                    string fullName = $"{user.FirstName} {user.LastName}";

#line default
#line hidden
            BeginContext(3246, 63, true);
            WriteLiteral("                                    <strong>Customer:</strong> ");
            EndContext();
            BeginContext(3310, 8, false);
#line 70 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\OrderDetails.cshtml"
                                                          Write(fullName);

#line default
#line hidden
            EndContext();
            BeginContext(3318, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
            BeginContext(3361, 61, true);
            WriteLiteral("                                <strong>Order Date:</strong> ");
            EndContext();
            BeginContext(3423, 15, false);
#line 72 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\OrderDetails.cshtml"
                                                        Write(Model.OrderDate);

#line default
#line hidden
            EndContext();
            BeginContext(3438, 366, true);
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
            BeginContext(3805, 23, false);
#line 82 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\OrderDetails.cshtml"
                       Write(Model.Address.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(3828, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3830, 22, false);
#line 82 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\OrderDetails.cshtml"
                                                Write(Model.Address.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(3852, 36, true);
            WriteLiteral("<br />\r\n                            ");
            EndContext();
            BeginContext(3889, 20, false);
#line 83 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\OrderDetails.cshtml"
                       Write(Model.Address.Street);

#line default
#line hidden
            EndContext();
            BeginContext(3909, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
#line 84 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\OrderDetails.cshtml"
                             if (Model.Address.Street2 != null)
                            {
                                

#line default
#line hidden
            BeginContext(4046, 21, false);
#line 86 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\OrderDetails.cshtml"
                           Write(Model.Address.Street2);

#line default
#line hidden
            EndContext();
            BeginContext(4067, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
#line 87 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\OrderDetails.cshtml"
                            }

#line default
#line hidden
            BeginContext(4106, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(4135, 18, false);
#line 88 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\OrderDetails.cshtml"
                       Write(Model.Address.City);

#line default
#line hidden
            EndContext();
            BeginContext(4153, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(4155, 19, false);
#line 88 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\OrderDetails.cshtml"
                                           Write(Model.Address.State);

#line default
#line hidden
            EndContext();
            BeginContext(4174, 36, true);
            WriteLiteral("<br />\r\n                            ");
            EndContext();
            BeginContext(4211, 17, false);
#line 89 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\OrderDetails.cshtml"
                       Write(Model.Address.Zip);

#line default
#line hidden
            EndContext();
            BeginContext(4228, 36, true);
            WriteLiteral("<br />\r\n                            ");
            EndContext();
            BeginContext(4265, 21, false);
#line 90 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\OrderDetails.cshtml"
                       Write(Model.Address.Country);

#line default
#line hidden
            EndContext();
            BeginContext(4286, 199, true);
            WriteLiteral("\r\n                        </p>\r\n                    </div>\r\n                    <div class=\"col-md-6 mb-3\">\r\n                        <h4 class=\"mb-3\">Shipping Method</h4>\r\n                        <p>");
            EndContext();
            BeginContext(4486, 14, false);
#line 95 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\OrderDetails.cshtml"
                      Write(Model.Shipping);

#line default
#line hidden
            EndContext();
            BeginContext(4500, 109, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n                <hr class=\"mb-4\">\r\n                ");
            EndContext();
            BeginContext(4609, 190, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b8d647783084d29b25871fda285acaa", async() => {
                BeginContext(4664, 128, true);
                WriteLiteral("\r\n                    <button class=\"btn btn-info btn-lg btn-block\" type=\"submit\">Return to Order Log</button>\r\n                ");
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
            BeginContext(4799, 50, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
