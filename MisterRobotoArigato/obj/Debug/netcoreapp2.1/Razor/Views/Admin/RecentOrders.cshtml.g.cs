#pragma checksum "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Views\Admin\RecentOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a64acfd6ada06898d9548a0ef7e802e3cf2dc1af"
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
#line 1 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Views\_ViewImports.cshtml"
using MisterRobotoArigato;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Views\Admin\RecentOrders.cshtml"
using MisterRobotoArigato.Models;

#line default
#line hidden
#line 3 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Views\_ViewImports.cshtml"
using MisterRobotoArigato.Models.ViewModel;

#line default
#line hidden
#line 1 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Views\Admin\RecentOrders.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a64acfd6ada06898d9548a0ef7e802e3cf2dc1af", @"/Views/Admin/RecentOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e8ae2ccbb7e94b73188ce3e6eb3a1d410ddbaed", @"/Views/_ViewImports.cshtml")]
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
#line 5 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Views\Admin\RecentOrders.cshtml"
  
    ViewData["Title"] = "RecentOrders";
    Layout = "_Layout";


#line default
#line hidden
            BeginContext(218, 105, true);
            WriteLiteral("\n<h2>Recent Orders</h2>\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
            EndContext();
            BeginContext(324, 48, false);
#line 17 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Views\Admin\RecentOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.Orders[0].ID));

#line default
#line hidden
            EndContext();
            BeginContext(372, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(425, 52, false);
#line 20 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Views\Admin\RecentOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.Orders[0].UserID));

#line default
#line hidden
            EndContext();
            BeginContext(477, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(530, 55, false);
#line 23 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Views\Admin\RecentOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.Orders[0].OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(585, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(638, 58, false);
#line 26 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Views\Admin\RecentOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.Orders[0].TotalItemQty));

#line default
#line hidden
            EndContext();
            BeginContext(696, 52, true);
            WriteLiteral("\n            </th>\n            <th>\n                ");
            EndContext();
            BeginContext(749, 51, false);
#line 29 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Views\Admin\RecentOrders.cshtml"
           Write(Html.DisplayNameFor(model => model.Orders[0].Total));

#line default
#line hidden
            EndContext();
            BeginContext(800, 117, true);
            WriteLiteral("\n            </th>\n            <th>\n                Options\n            </th>\n        </tr>\n    </thead>\n    <tbody>\n");
            EndContext();
#line 37 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Views\Admin\RecentOrders.cshtml"
         foreach (var item in Model.Orders)
        {

#line default
#line hidden
            BeginContext(971, 58, true);
            WriteLiteral("            <tr>\n                <td>\n                    ");
            EndContext();
            BeginContext(1030, 37, false);
#line 41 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Views\Admin\RecentOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1067, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1132, 41, false);
#line 44 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Views\Admin\RecentOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.UserID));

#line default
#line hidden
            EndContext();
            BeginContext(1173, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1238, 44, false);
#line 47 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Views\Admin\RecentOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.OrderDate));

#line default
#line hidden
            EndContext();
            BeginContext(1282, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1347, 47, false);
#line 50 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Views\Admin\RecentOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.TotalItemQty));

#line default
#line hidden
            EndContext();
            BeginContext(1394, 64, true);
            WriteLiteral("\n                </td>\n                <td>\n                    ");
            EndContext();
            BeginContext(1459, 40, false);
#line 53 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Views\Admin\RecentOrders.cshtml"
               Write(Html.DisplayFor(modelItem => item.Total));

#line default
#line hidden
            EndContext();
            BeginContext(1499, 107, true);
            WriteLiteral("\n                </td>\n                <td>\n                    <a href=\"#\">Edit</a> |\n                    ");
            EndContext();
            BeginContext(1606, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ce7b10265b37405b91ee625a60309b81", async() => {
                BeginContext(1659, 7, true);
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
#line 57 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Views\Admin\RecentOrders.cshtml"
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
            BeginContext(1670, 23, true);
            WriteLiteral(" |\n                    ");
            EndContext();
            BeginContext(1693, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4cb6a7779ec64dfe8bfeed31dcd59a24", async() => {
                BeginContext(1745, 6, true);
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
#line 58 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Views\Admin\RecentOrders.cshtml"
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
            BeginContext(1755, 41, true);
            WriteLiteral("\n                </td>\n            </tr>\n");
            EndContext();
#line 61 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Views\Admin\RecentOrders.cshtml"
        }

#line default
#line hidden
            BeginContext(1806, 140, true);
            WriteLiteral("    </tbody>\n</table>\n<input type=\"button\" class=\"btn btn-info\" value=\"Return to Admin Dashboard\" onclick=\"window.location.href=\'/Admin\'\" />");
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
