#pragma checksum "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f668a872e3c6f5340579a650508381abfb96e55"
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
#line 1 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\_ViewImports.cshtml"
using Ecommerce;

#line default
#line hidden
#line 5 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\_ViewImports.cshtml"
using Ecommerce.Models;

#line default
#line hidden
#line 3 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\_ViewImports.cshtml"
using Ecommerce.Models.ViewModel;

#line default
#line hidden
#line 4 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4f668a872e3c6f5340579a650508381abfb96e55", @"/Pages/Orders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4659f17248f0e019fe19d081499f101d0de08d56", @"/Pages/_ViewImports.cshtml")]
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
#line 3 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
  
    ViewData["Title"] = "Orders";
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(110, 95, true);
            WriteLiteral("\r\n<div class=\"py-5 text-center\">\r\n    <h2>Recent Orders</h2>\r\n</div>\r\n<div class=\"container\">\r\n");
            EndContext();
#line 12 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
     foreach (Order order in Model.Orders)
    {

#line default
#line hidden
            BeginContext(256, 392, true);
            WriteLiteral(@"        <section class=""order"">
            <div class=""row"">
                <div class=""col-md-4 order-md-2 mb-4"">
                    <h4 class=""d-flex justify-content-between align-items-center mb-3"">
                        <span class=""text-muted"">Your checkout bag</span>
                        <span class=""badge badge-secondary badge-pill""><i class=""fas fa-shopping-bag""></i>  ");
            EndContext();
            BeginContext(649, 18, false);
#line 19 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
                                                                                                       Write(order.TotalItemQty);

#line default
#line hidden
            EndContext();
            BeginContext(667, 88, true);
            WriteLiteral("</span>\r\n\r\n                    </h4>\r\n                    <ul class=\"list-group mb-3\">\r\n");
            EndContext();
#line 23 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
                          
                            decimal orderTotal = 0;
                        

#line default
#line hidden
            BeginContext(863, 24, true);
            WriteLiteral("                        ");
            EndContext();
#line 26 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
                         foreach (var orderItem in order.OrderItems)
                        {
                            var totalItemPrice = orderItem.UnitPrice * orderItem.Quantity;
                            orderTotal += totalItemPrice;

#line default
#line hidden
            BeginContext(1111, 213, true);
            WriteLiteral("                            <li class=\"list-group-item d-flex justify-content-between lh-condensed\">\r\n                                <div class=\"float-left\">\r\n                                    <h6 class=\"my-0\">");
            EndContext();
            BeginContext(1325, 21, false);
#line 32 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
                                                Write(orderItem.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(1346, 79, true);
            WriteLiteral("</h6>\r\n                                    <small class=\"text-muted\">Quantity: ");
            EndContext();
            BeginContext(1426, 18, false);
#line 33 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
                                                                   Write(orderItem.Quantity);

#line default
#line hidden
            EndContext();
            BeginContext(1444, 86, true);
            WriteLiteral("</small>\r\n                                </div>\r\n                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1530, "\"", 1553, 1);
#line 35 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
WriteAttributeValue("", 1536, orderItem.ImgUrl, 1536, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1554, 81, true);
            WriteLiteral(" class=\"checkout-img\">\r\n                                <span class=\"text-muted\">");
            EndContext();
            BeginContext(1636, 14, false);
#line 36 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
                                                    Write(totalItemPrice);

#line default
#line hidden
            EndContext();
            BeginContext(1650, 44, true);
            WriteLiteral("</span>\r\n                            </li>\r\n");
            EndContext();
#line 38 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
                        }

#line default
#line hidden
            BeginContext(1721, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 40 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
                         if (order.DiscountPercent != 0)
                        {
                            decimal discountAmt = (order.DiscountPercent / 100) * orderTotal;

#line default
#line hidden
            BeginContext(1903, 201, true);
            WriteLiteral("                            <li class=\"list-group-item d-flex justify-content-between bg-light\">\r\n                                <h6 class=\"my-0\">Subtotal</h6>\r\n                                <span>$");
            EndContext();
            BeginContext(2105, 14, false);
#line 45 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
                                  Write(order.Subtotal);

#line default
#line hidden
            EndContext();
            BeginContext(2119, 315, true);
            WriteLiteral(@"</span>
                            </li>
                            <li class=""list-group-item d-flex justify-content-between bg-light"">
                                <div class=""text-success"">
                                    <h6 class=""my-0"">Promo code</h6>
                                    <small>");
            EndContext();
            BeginContext(2435, 18, false);
#line 50 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
                                      Write(order.DiscountName);

#line default
#line hidden
            EndContext();
            BeginContext(2453, 111, true);
            WriteLiteral("</small>\r\n                                </div>\r\n                                <span class=\"text-success\">-$");
            EndContext();
            BeginContext(2565, 17, false);
#line 52 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
                                                        Write(order.DiscountAmt);

#line default
#line hidden
            EndContext();
            BeginContext(2582, 44, true);
            WriteLiteral("</span>\r\n                            </li>\r\n");
            EndContext();
#line 54 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
                        }

#line default
#line hidden
            BeginContext(2653, 139, true);
            WriteLiteral("                        <li class=\"list-group-item d-flex justify-content-between\">\r\n                            <span>Total (USD)</span>\r\n");
            EndContext();
            BeginContext(2824, 41, true);
            WriteLiteral("                                <strong>$");
            EndContext();
            BeginContext(2866, 11, false);
#line 58 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
                                    Write(order.Total);

#line default
#line hidden
            EndContext();
            BeginContext(2877, 11, true);
            WriteLiteral("</strong>\r\n");
            EndContext();
            BeginContext(2919, 277, true);
            WriteLiteral(@"                        </li>
                    </ul>
                </div>
                <div class=""col-md-8 order-md-1"">
                    <div class=""row"">
                        <div class=""col-md-6 mb-3"">
                            <h4 class=""mb-3"">Order #");
            EndContext();
            BeginContext(3197, 8, false);
#line 66 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
                                               Write(order.ID);

#line default
#line hidden
            EndContext();
            BeginContext(3205, 165, true);
            WriteLiteral("</h4>\r\n                            <p>\r\n                                <div class=\"d-inline-block\">\r\n                                    <strong>Customer:</strong> ");
            EndContext();
            BeginContext(3371, 15, false);
#line 69 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
                                                          Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(3386, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3388, 14, false);
#line 69 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
                                                                           Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(3402, 73, true);
            WriteLiteral("<br />\r\n                                    <strong>Order Date:</strong> ");
            EndContext();
            BeginContext(3476, 15, false);
#line 70 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
                                                            Write(order.OrderDate);

#line default
#line hidden
            EndContext();
            BeginContext(3491, 406, true);
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
            BeginContext(3898, 23, false);
#line 80 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
                           Write(order.Address.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(3921, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3923, 22, false);
#line 80 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
                                                    Write(order.Address.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(3945, 40, true);
            WriteLiteral("<br />\r\n                                ");
            EndContext();
            BeginContext(3986, 20, false);
#line 81 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
                           Write(order.Address.Street);

#line default
#line hidden
            EndContext();
            BeginContext(4006, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
#line 82 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
                                 if (order.Address.Street2 != null)
                                {
                                    

#line default
#line hidden
            BeginContext(4155, 21, false);
#line 84 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
                               Write(order.Address.Street2);

#line default
#line hidden
            EndContext();
            BeginContext(4176, 8, true);
            WriteLiteral("<br />\r\n");
            EndContext();
#line 85 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
                                }

#line default
#line hidden
            BeginContext(4219, 32, true);
            WriteLiteral("                                ");
            EndContext();
            BeginContext(4252, 18, false);
#line 86 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
                           Write(order.Address.City);

#line default
#line hidden
            EndContext();
            BeginContext(4270, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(4272, 19, false);
#line 86 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
                                               Write(order.Address.State);

#line default
#line hidden
            EndContext();
            BeginContext(4291, 40, true);
            WriteLiteral("<br />\r\n                                ");
            EndContext();
            BeginContext(4332, 17, false);
#line 87 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
                           Write(order.Address.Zip);

#line default
#line hidden
            EndContext();
            BeginContext(4349, 40, true);
            WriteLiteral("<br />\r\n                                ");
            EndContext();
            BeginContext(4390, 21, false);
#line 88 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
                           Write(order.Address.Country);

#line default
#line hidden
            EndContext();
            BeginContext(4411, 219, true);
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n                        <div class=\"col-md-6 mb-3\">\r\n                            <h4 class=\"mb-3\">Shipping Method</h4>\r\n                            <p>");
            EndContext();
            BeginContext(4631, 14, false);
#line 93 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
                          Write(order.Shipping);

#line default
#line hidden
            EndContext();
            BeginContext(4645, 125, true);
            WriteLiteral("</p>\r\n                        </div>\r\n                    </div>\r\n                    <hr class=\"mb-4\">\r\n                    ");
            EndContext();
            BeginContext(4770, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a280d0518e94f3e9a166f2358347ebf", async() => {
                BeginContext(4885, 12, true);
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
#line 97 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
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
            BeginContext(4901, 68, true);
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n        </section>\r\n");
            EndContext();
#line 102 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Pages\Orders.cshtml"
    }

#line default
#line hidden
            BeginContext(4976, 45, true);
            WriteLiteral("</div>\r\n<br />\r\n<div class=\"container\">\r\n    ");
            EndContext();
            BeginContext(5021, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5e62a88d2ea4d8fa6c209db2f3c7547", async() => {
                BeginContext(5124, 17, true);
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
            BeginContext(5145, 18, true);
            WriteLiteral("\r\n</div>\r\n<br />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ecommerce.Pages.OrdersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ecommerce.Pages.OrdersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ecommerce.Pages.OrdersModel>)PageContext?.ViewData;
        public Ecommerce.Pages.OrdersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
