#pragma checksum "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\ViewAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1391b7cf55a131a2610e902e9beef5729f63e99"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_ViewAll), @"mvc.1.0.view", @"/Views/Admin/ViewAll.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/ViewAll.cshtml", typeof(AspNetCore.Views_Admin_ViewAll))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1391b7cf55a131a2610e902e9beef5729f63e99", @"/Views/Admin/ViewAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4659f17248f0e019fe19d081499f101d0de08d56", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_ViewAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListingVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\ViewAll.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(57, 131, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(189, 50, false);
#line 11 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\ViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.Products[0].ID));

#line default
#line hidden
            EndContext();
            BeginContext(239, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(307, 52, false);
#line 14 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\ViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.Products[0].Name));

#line default
#line hidden
            EndContext();
            BeginContext(359, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(427, 51, false);
#line 17 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\ViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.Products[0].SKU));

#line default
#line hidden
            EndContext();
            BeginContext(478, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(546, 53, false);
#line 20 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\ViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.Products[0].Price));

#line default
#line hidden
            EndContext();
            BeginContext(599, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(667, 59, false);
#line 23 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\ViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.Products[0].Description));

#line default
#line hidden
            EndContext();
            BeginContext(726, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(794, 54, false);
#line 26 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\ViewAll.cshtml"
               Write(Html.DisplayNameFor(model => model.Products[0].ImgUrl));

#line default
#line hidden
            EndContext();
            BeginContext(848, 155, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    Options\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n\r\n");
            EndContext();
#line 35 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\ViewAll.cshtml"
             foreach (var product in Model.Products)
            {

#line default
#line hidden
            BeginContext(1072, 72, true);
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1145, 40, false);
#line 39 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\ViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => product.ID));

#line default
#line hidden
            EndContext();
            BeginContext(1185, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1265, 42, false);
#line 42 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\ViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => product.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1307, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1387, 41, false);
#line 45 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\ViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => product.SKU));

#line default
#line hidden
            EndContext();
            BeginContext(1428, 80, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        $");
            EndContext();
            BeginContext(1509, 43, false);
#line 48 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\ViewAll.cshtml"
                    Write(Html.DisplayFor(modelItem => product.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1552, 79, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1632, 49, false);
#line 51 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\ViewAll.cshtml"
                   Write(Html.DisplayFor(modelItem => product.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1681, 83, true);
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1764, "\"", 1815, 1);
#line 54 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\ViewAll.cshtml"
WriteAttributeValue("", 1770, Html.DisplayFor(modelItem => product.ImgUrl), 1770, 45, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1816, 102, true);
            WriteLiteral(" class=\"smaller-img\" />\r\n                    </td>\r\n                    <td>\r\n                        ");
            EndContext();
            BeginContext(1918, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdbfc1cf03e64ebe99aae821951d66aa", async() => {
                BeginContext(1966, 4, true);
                WriteLiteral("Edit");
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
#line 57 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\ViewAll.cshtml"
                                               WriteLiteral(product.ID);

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
            BeginContext(1974, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2000, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53488c7c422c431ba65c694f1da89f58", async() => {
                BeginContext(2051, 7, true);
                WriteLiteral("Details");
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
#line 58 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\ViewAll.cshtml"
                                                  WriteLiteral(product.ID);

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
            BeginContext(2062, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(2088, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c26c04b77b94f7f95b02dffcf04a194", async() => {
                BeginContext(2138, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\ViewAll.cshtml"
                                                 WriteLiteral(product.ID);

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
            BeginContext(2148, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 62 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Admin\ViewAll.cshtml"
            }

#line default
#line hidden
            BeginContext(2215, 38, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProductListingVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
