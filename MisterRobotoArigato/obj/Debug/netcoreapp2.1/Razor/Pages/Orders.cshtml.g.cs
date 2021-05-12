#pragma checksum "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8588f84f6ae6fd535d08c58c309229d4db944ed9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Orders), @"mvc.1.0.razor-page", @"/Pages/Orders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Orders.cshtml", typeof(AspNetCore.Pages_Orders), null)]
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
#line 1 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\_ViewImports.cshtml"
using MisterRobotoArigato;

#line default
#line hidden
#line 5 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\_ViewImports.cshtml"
using MisterRobotoArigato.Models;

#line default
#line hidden
#line 3 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\_ViewImports.cshtml"
using MisterRobotoArigato.Models.ViewModel;

#line default
#line hidden
#line 4 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8588f84f6ae6fd535d08c58c309229d4db944ed9", @"/Pages/Orders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e8ae2ccbb7e94b73188ce3e6eb3a1d410ddbaed", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Orders : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-lg btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success btn-lg btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("return-shop"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
  
    ViewData["Title"] = "Orders";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(114, 90, true);
            WriteLiteral("\n<div class=\"py-5 text-center\">\n    <h2>Recent Orders</h2>\n</div>\n<div class=\"container\">\n");
            EndContext();
#line 12 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
     foreach (Order order in Model.Orders)
    {

#line default
#line hidden
            BeginContext(253, 387, true);
            WriteLiteral(@"        <section class=""order"">
            <div class=""row"">
                <div class=""col-md-4 order-md-2 mb-4"">
                    <h4 class=""d-flex justify-content-between align-items-center mb-3"">
                        <span class=""text-muted"">Your checkout bag</span>
                        <span class=""badge badge-secondary badge-pill""><i class=""fas fa-shopping-bag""></i>  ");
            EndContext();
            BeginContext(641, 18, false);
#line 19 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
                                                                                                       Write(order.TotalItemQty);

#line default
#line hidden
            EndContext();
            BeginContext(659, 84, true);
            WriteLiteral("</span>\n\n                    </h4>\n                    <ul class=\"list-group mb-3\">\n");
            EndContext();
#line 23 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
                          
                            decimal orderTotal = 0;
                        

#line default
#line hidden
            BeginContext(848, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 26 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
                         foreach (var orderItem in order.OrderItems)
                        {
                            var totalItemPrice = orderItem.UnitPrice * orderItem.Quantity;
                            orderTotal += totalItemPrice;

#line default
#line hidden
            BeginContext(1092, 211, true);
            WriteLiteral("                            <li class=\"list-group-item d-flex justify-content-between lh-condensed\">\n                                <div class=\"float-left\">\n                                    <h6 class=\"my-0\">");
            EndContext();
            BeginContext(1304, 21, false);
#line 32 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
                                                Write(orderItem.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(1325, 78, true);
            WriteLiteral("</h6>\n                                    <small class=\"text-muted\">Quantity: ");
            EndContext();
            BeginContext(1404, 18, false);
#line 33 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
                                                                   Write(orderItem.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1422, 84, true);
            WriteLiteral("</small>\n                                </div>\n                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1506, "\"", 1529, 1);
#line 35 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
WriteAttributeValue("", 1512, orderItem.ImgUrl, 1512, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1530, 80, true);
            WriteLiteral(" class=\"checkout-img\">\n                                <span class=\"text-muted\">");
            EndContext();
            BeginContext(1611, 14, false);
#line 36 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
                                                    Write(totalItemPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1625, 42, true);
            WriteLiteral("</span>\n                            </li>\n");
            EndContext();
#line 38 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
                        }

#line default
#line hidden
            BeginContext(1693, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 40 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
                         if (order.DiscountPercent != 0)
                        {
                            decimal discountAmt = (order.DiscountPercent / 100) * orderTotal;

#line default
#line hidden
            BeginContext(1871, 199, true);
            WriteLiteral("                            <li class=\"list-group-item d-flex justify-content-between bg-light\">\n                                <h6 class=\"my-0\">Subtotal</h6>\n                                <span>$");
            EndContext();
            BeginContext(2071, 14, false);
#line 45 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
                                  Write(order.Subtotal);

#line default
#line hidden
            EndContext();
            BeginContext(2085, 310, true);
            WriteLiteral(@"</span>
                            </li>
                            <li class=""list-group-item d-flex justify-content-between bg-light"">
                                <div class=""text-success"">
                                    <h6 class=""my-0"">Promo code</h6>
                                    <small>");
            EndContext();
            BeginContext(2396, 18, false);
#line 50 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
                                      Write(order.DiscountName);

#line default
#line hidden
            EndContext();
            BeginContext(2414, 109, true);
            WriteLiteral("</small>\n                                </div>\n                                <span class=\"text-success\">-$");
            EndContext();
            BeginContext(2524, 17, false);
#line 52 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
                                                        Write(order.DiscountAmt);

#line default
#line hidden
            EndContext();
            BeginContext(2541, 42, true);
            WriteLiteral("</span>\n                            </li>\n");
            EndContext();
#line 54 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
                        }

#line default
#line hidden
            BeginContext(2609, 137, true);
            WriteLiteral("                        <li class=\"list-group-item d-flex justify-content-between\">\n                            <span>Total (USD)</span>\n");
            EndContext();
            BeginContext(2777, 41, true);
            WriteLiteral("                                <strong>$");
            EndContext();
            BeginContext(2819, 11, false);
#line 58 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
                                    Write(order.Total);

#line default
#line hidden
            EndContext();
            BeginContext(2830, 10, true);
            WriteLiteral("</strong>\n");
            EndContext();
            BeginContext(2870, 271, true);
            WriteLiteral(@"                        </li>
                    </ul>
                </div>
                <div class=""col-md-8 order-md-1"">
                    <div class=""row"">
                        <div class=""col-md-6 mb-3"">
                            <h4 class=""mb-3"">Order #");
            EndContext();
            BeginContext(3142, 8, false);
#line 66 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
                                               Write(order.ID);

#line default
#line hidden
            EndContext();
            BeginContext(3150, 162, true);
            WriteLiteral("</h4>\n                            <p>\n                                <div class=\"d-inline-block\">\n                                    <strong>Customer:</strong> ");
            EndContext();
            BeginContext(3313, 15, false);
#line 69 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
                                                          Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(3328, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3330, 14, false);
#line 69 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
                                                                           Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(3344, 72, true);
            WriteLiteral("<br />\n                                    <strong>Order Date:</strong> ");
            EndContext();
            BeginContext(3417, 15, false);
#line 70 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
                                                            Write(order.OrderDate);

#line default
#line hidden
            EndContext();
            BeginContext(3432, 396, true);
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
            BeginContext(3829, 23, false);
#line 80 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
                           Write(order.Address.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(3852, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3854, 22, false);
#line 80 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
                                                    Write(order.Address.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(3876, 39, true);
            WriteLiteral("<br />\n                                ");
            EndContext();
            BeginContext(3916, 20, false);
#line 81 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
                           Write(order.Address.Street);

#line default
#line hidden
            EndContext();
            BeginContext(3936, 7, true);
            WriteLiteral("<br />\n");
            EndContext();
#line 82 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
                                 if (order.Address.Street2 != null)
                                {
                                    

#line default
#line hidden
            BeginContext(4082, 21, false);
#line 84 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
                               Write(order.Address.Street2);

#line default
#line hidden
            EndContext();
            BeginContext(4103, 7, true);
            WriteLiteral("<br />\n");
            EndContext();
#line 85 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
                                }

#line default
#line hidden
            BeginContext(4144, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(4177, 18, false);
#line 86 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
                           Write(order.Address.City);

#line default
#line hidden
            EndContext();
            BeginContext(4195, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(4197, 19, false);
#line 86 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
                                               Write(order.Address.State);

#line default
#line hidden
            EndContext();
            BeginContext(4216, 39, true);
            WriteLiteral("<br />\n                                ");
            EndContext();
            BeginContext(4256, 17, false);
#line 87 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
                           Write(order.Address.Zip);

#line default
#line hidden
            EndContext();
            BeginContext(4273, 39, true);
            WriteLiteral("<br />\n                                ");
            EndContext();
            BeginContext(4313, 21, false);
#line 88 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
                           Write(order.Address.Country);

#line default
#line hidden
            EndContext();
            BeginContext(4334, 214, true);
            WriteLiteral("\n                            </p>\n                        </div>\n                        <div class=\"col-md-6 mb-3\">\n                            <h4 class=\"mb-3\">Shipping Method</h4>\n                            <p>");
            EndContext();
            BeginContext(4549, 14, false);
#line 93 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
                          Write(order.Shipping);

#line default
#line hidden
            EndContext();
            BeginContext(4563, 121, true);
            WriteLiteral("</p>\n                        </div>\n                    </div>\n                    <hr class=\"mb-4\">\n                    ");
            EndContext();
            BeginContext(4684, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d39edcca890844588da93beaf67f5f27", async() => {
                BeginContext(4799, 12, true);
                WriteLiteral("Cancel Order");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 97 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
                                                                                                                WriteLiteral(order.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4815, 63, true);
            WriteLiteral("\n\n                </div>\n            </div>\n        </section>\n");
            EndContext();
#line 102 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Pages\Orders.cshtml"
    }

#line default
#line hidden
            BeginContext(4884, 42, true);
            WriteLiteral("</div>\n<br />\n<div class=\"container\">\n    ");
            EndContext();
            BeginContext(4926, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5b4e54a7cf94772b5ccf702f28712bc", async() => {
                BeginContext(5029, 17, true);
                WriteLiteral("Continue Shopping");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
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
            BeginContext(5050, 15, true);
            WriteLiteral("\n</div>\n<br />\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MisterRobotoArigato.Pages.OrdersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MisterRobotoArigato.Pages.OrdersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MisterRobotoArigato.Pages.OrdersModel>)PageContext?.ViewData;
        public MisterRobotoArigato.Pages.OrdersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
