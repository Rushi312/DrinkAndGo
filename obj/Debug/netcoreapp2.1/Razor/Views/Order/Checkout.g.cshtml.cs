#pragma checksum "D:\project\FoodAndGo\FoodAndGo\Views\Order\Checkout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1311be51457844f3525efb3220a1dd0b0d5d6e4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Checkout), @"mvc.1.0.view", @"/Views/Order/Checkout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/Checkout.cshtml", typeof(AspNetCore.Views_Order_Checkout))]
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
#line 1 "D:\project\FoodAndGo\FoodAndGo\Views\_ViewImports.cshtml"
using DrinkAndGo.Data.Models;

#line default
#line hidden
#line 2 "D:\project\FoodAndGo\FoodAndGo\Views\_ViewImports.cshtml"
using DrinkAndGo.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1311be51457844f3525efb3220a1dd0b0d5d6e4a", @"/Views/Order/Checkout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba8efd8a15e8c05b47b8942b2308a9b3bfdc6a7a", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_Checkout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 10, true);
            WriteLiteral("<h1>\r\n    ");
            EndContext();
            BeginContext(11, 31, false);
#line 2 "D:\project\FoodAndGo\FoodAndGo\Views\Order\Checkout.cshtml"
Write(ViewBag.CheckoutCompleteMessage);

#line default
#line hidden
            EndContext();
            BeginContext(42, 7, true);
            WriteLiteral("\r\n</h1>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591