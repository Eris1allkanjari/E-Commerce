#pragma checksum "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Shared\Components\ShoppingCart\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "adc13e555eb0bf51e7c316c4cfc7c3af6af1fdaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ShoppingCart_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ShoppingCart/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/ShoppingCart/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_ShoppingCart_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"adc13e555eb0bf51e7c316c4cfc7c3af6af1fdaa", @"/Views/Shared/Components/ShoppingCart/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4659f17248f0e019fe19d081499f101d0de08d56", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ShoppingCart_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Basket>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(15, 224, true);
            WriteLiteral("\r\n<span style=\"font-size:20px;cursor:pointer\" onclick=\"openNav()\">View Basket Contents</span>\r\n\r\n<div id=\"basket\">\r\n    <h4>Basket Contents</h4>\r\n    <a href=\"javascript:void(0)\" class=\"closebtn\" onclick=\"closeNav()\">X</a>\r\n");
            EndContext();
#line 8 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Shared\Components\ShoppingCart\Default.cshtml"
     foreach (var product in Model.BasketItems)
    {

#line default
#line hidden
            BeginContext(295, 11, true);
            WriteLiteral("        <p>");
            EndContext();
            BeginContext(307, 19, false);
#line 10 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Shared\Components\ShoppingCart\Default.cshtml"
      Write(product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(326, 18, true);
            WriteLiteral("</p>\r\n        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 344, "\"", 365, 1);
#line 11 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Shared\Components\ShoppingCart\Default.cshtml"
WriteAttributeValue("", 350, product.ImgUrl, 350, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(366, 136, true);
            WriteLiteral(" class=\"smaller-img\" />\r\n        <p>\r\n            <label for=\"quantity\">Quantity</label>\r\n            <input id=\"quantity\" type=\"number\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 502, "\"", 527, 1);
#line 14 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Shared\Components\ShoppingCart\Default.cshtml"
WriteAttributeValue("", 510, product.Quantity, 510, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(528, 36, true);
            WriteLiteral(" min=\"1\">\r\n        </p>\r\n        <p>");
            EndContext();
            BeginContext(565, 17, false);
#line 16 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Shared\Components\ShoppingCart\Default.cshtml"
      Write(product.UnitPrice);

#line default
#line hidden
            EndContext();
            BeginContext(582, 22, true);
            WriteLiteral("</p>\r\n        <hr />\r\n");
            EndContext();
#line 18 "C:\Users\User\Desktop\Projects\eCommerce-master\EcommerceApp\ECommerce\Views\Shared\Components\ShoppingCart\Default.cshtml"
    }

#line default
#line hidden
            BeginContext(611, 227, true);
            WriteLiteral("</div>\r\n \r\n<script>\r\n    function openNav() {\r\n        document.getElementById(\"basket\").style.width = \"450px\";\r\n    }\r\n\r\n    function closeNav() {\r\n        document.getElementById(\"basket\").style.width = \"0\";\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Basket> Html { get; private set; }
    }
}
#pragma warning restore 1591
