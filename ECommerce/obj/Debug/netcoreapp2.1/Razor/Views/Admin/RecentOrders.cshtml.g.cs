#pragma checksum "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\RecentOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8743a3b1b9cc877700e8119be37a3cb3e544b46"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_RecentOrders), @"mvc.1.0.view", @"/Views/Admin/RecentOrders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/RecentOrders.cshtml", typeof(AspNetCore.Views_Admin_RecentOrders))]
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
#line 2 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\RecentOrders.cshtml"
using Ecommerce.Models;

#line default
#line hidden
#line 3 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\_ViewImports.cshtml"
using Ecommerce.Models.ViewModel;

#line default
#line hidden
#line 1 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\RecentOrders.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8743a3b1b9cc877700e8119be37a3cb3e544b46", @"/Views/Admin/RecentOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4659f17248f0e019fe19d081499f101d0de08d56", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_RecentOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OrderListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteOrder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\RecentOrders.cshtml"
  
    ViewData["Title"] = "RecentOrders";
    Layout = "_Layout";


#line default
#line hidden
            BeginContext(217, 112, true);
            WriteLiteral("\r\n<h2>Recent Orders</h2>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(330, 48, false);
#line 17 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\RecentOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.Orders[0].ID));

#line default
#line hidden
            EndContext();
            BeginContext(378, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(434, 52, false);
#line 20 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\RecentOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.Orders[0].UserID));

#line default
#line hidden
            EndContext();
            BeginContext(486, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(542, 55, false);
#line 23 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\RecentOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.Orders[0].OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(597, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(653, 58, false);
#line 26 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\RecentOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.Orders[0].TotalItemQty));

#line default
#line hidden
            EndContext();
            BeginContext(711, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(767, 51, false);
#line 29 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\RecentOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.Orders[0].Total));

#line default
#line hidden
            EndContext();
            BeginContext(818, 125, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Options\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 37 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\RecentOrders.cshtml"
         foreach (var item in Model.Orders)
        {

#line default
#line hidden
            BeginContext(999, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1060, 37, false);
#line 41 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\RecentOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1097, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1165, 41, false);
#line 44 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\RecentOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.UserID));

#line default
#line hidden
            EndContext();
            BeginContext(1206, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1274, 44, false);
#line 47 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\RecentOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(1318, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1386, 47, false);
#line 50 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\RecentOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.TotalItemQty));

#line default
#line hidden
            EndContext();
            BeginContext(1433, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1501, 40, false);
#line 53 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\RecentOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.Total));

#line default
#line hidden
            EndContext();
            BeginContext(1541, 111, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <a href=\"#\">Edit</a> |\r\n                    ");
            EndContext();
            BeginContext(1652, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2379e0d5cfd49c8b5cb28988332df2b", async() => {
                BeginContext(1705, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 57 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\RecentOrders.cshtml"
                                                   WriteLiteral(item.ID);

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
            BeginContext(1716, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(1740, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26699277225d45949591793f9bc1a9e0", async() => {
                BeginContext(1792, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\RecentOrders.cshtml"
                                                  WriteLiteral(item.ID);

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
            BeginContext(1802, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 61 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\RecentOrders.cshtml"
        }

#line default
#line hidden
            BeginContext(1857, 142, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<input type=\"button\" class=\"btn btn-info\" value=\"Return to Admin Dashboard\" onclick=\"window.location.href=\'/Admin\'\" />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OrderListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
