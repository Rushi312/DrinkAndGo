#pragma checksum "D:\project\FoodAndGo\FoodAndGo\Views\Drink\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "de65002738d9c390082dc4763a5ddbd1302beeb3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Drink_List), @"mvc.1.0.view", @"/Views/Drink/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Drink/List.cshtml", typeof(AspNetCore.Views_Drink_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de65002738d9c390082dc4763a5ddbd1302beeb3", @"/Views/Drink/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba8efd8a15e8c05b47b8942b2308a9b3bfdc6a7a", @"/Views/_ViewImports.cshtml")]
    public class Views_Drink_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DrinksListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 31, true);
            WriteLiteral("\r\n<div class=\"row marginTop\">\r\n");
            EndContext();
#line 4 "D:\project\FoodAndGo\FoodAndGo\Views\Drink\List.cshtml"
     foreach (var drink in Model.Drinks)
    {
        

#line default
#line hidden
            BeginContext(117, 36, false);
#line 6 "D:\project\FoodAndGo\FoodAndGo\Views\Drink\List.cshtml"
   Write(Html.Partial("DrinksSummary", drink));

#line default
#line hidden
            EndContext();
#line 6 "D:\project\FoodAndGo\FoodAndGo\Views\Drink\List.cshtml"
                                             
    }

#line default
#line hidden
            BeginContext(162, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DrinksListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
