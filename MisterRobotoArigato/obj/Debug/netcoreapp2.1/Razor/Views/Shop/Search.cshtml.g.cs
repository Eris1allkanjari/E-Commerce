#pragma checksum "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Views\Shop\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1f38c4c43e8a889561cfc1199217041c95ca909"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Search), @"mvc.1.0.view", @"/Views/Shop/Search.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shop/Search.cshtml", typeof(AspNetCore.Views_Shop_Search))]
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
#line 5 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Views\_ViewImports.cshtml"
using MisterRobotoArigato.Models;

#line default
#line hidden
#line 3 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Views\_ViewImports.cshtml"
using MisterRobotoArigato.Models.ViewModel;

#line default
#line hidden
#line 4 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1f38c4c43e8a889561cfc1199217041c95ca909", @"/Views/Shop/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e8ae2ccbb7e94b73188ce3e6eb3a1d410ddbaed", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProductListingVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Views\Shop\Search.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(53, 53, true);
            WriteLiteral("\n<div class=\"container\">\n    <h3>Search Results</h3>\n");
            EndContext();
#line 8 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Views\Shop\Search.cshtml"
     foreach (var p in Model.Products)
    {

#line default
#line hidden
            BeginContext(151, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(163, 6, false);
#line 10 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Views\Shop\Search.cshtml"
      Write(p.Name);

#line default
#line hidden
            EndContext();
            BeginContext(169, 17, true);
            WriteLiteral("</p>\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 186, "\"", 201, 1);
#line 11 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Views\Shop\Search.cshtml"
WriteAttributeValue("", 192, p.ImgUrl, 192, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(202, 4, true);
            WriteLiteral(" />\n");
            EndContext();
            BeginContext(207, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(215, 83, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64de5f2173bf48718fc3890586986c28", async() => {
                BeginContext(282, 12, true);
                WriteLiteral("View Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 13 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Views\Shop\Search.cshtml"
                                                        WriteLiteral(p.ID);

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
            BeginContext(298, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 14 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Views\Shop\Search.cshtml"
    }

#line default
#line hidden
            BeginContext(305, 74, true);
            WriteLiteral("    <button class=\"btn btn-primary\" title=\"View Basket Contents\">\n        ");
            EndContext();
            BeginContext(380, 43, false);
#line 16 "C:\Users\User\Desktop\Projects\eCommerce-master\MisterRobotoArigato\MisterRobotoArigato\Views\Shop\Search.cshtml"
   Write(await Component.InvokeAsync("ShoppingCart"));

#line default
#line hidden
            EndContext();
            BeginContext(423, 21, true);
            WriteLiteral("\n    </button>\n</div>");
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
