#pragma checksum "D:\project\FoodAndGo\FoodAndGo\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aaa10abc34b450573c5ab42e15ef676673f1c259"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/About/Index.cshtml", typeof(AspNetCore.Views_About_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaa10abc34b450573c5ab42e15ef676673f1c259", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba8efd8a15e8c05b47b8942b2308a9b3bfdc6a7a", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::DrinkAndGo.TagHelpers.MyBoldTagHelper __DrinkAndGo_TagHelpers_MyBoldTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1569, true);
            WriteLiteral(@"<h1>Welcome to ASP.NET Core!</h1>

<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-12"">
            <h2>What is ASP.NET Core?`</h2>
            <p>
                ASP.NET Core is a lean and composable framework for building web and cloud applications. ASP.NET Core is fully open source and available on GitHub.
                ASP.NET Core is available on Windows, Mac, and Linux.
            </p>
        </div>

        <div class=""col-md-12"">
            <h2>Why build ASP.NET Core?</h2>
            <p>
                The first preview release of ASP.NET came out almost 15 years ago as part of the .NET Framework. Since then millions of developers have used it to build and run great web apps, and over the years we have added and evolved many capabilities to it.
                ASP.NET Core has a number of architectural changes that result in a much leaner and modular framework. ASP.NET Core is no longer based on System.Web.dll. It is based on a set of granular and");
            WriteLiteral(@" well factored NuGet packages. This allows you to optimize your app to include just the NuGet packages you need. The benefits of a smaller app surface area include tighter security, reduced servicing, improved performance, and decreased costs in a pay-for-what-you-use model.
            </p>
        </div>

        <div class=""col-md-12"">
            <h2>What is this project all about</h2>
            <p>
                This project is just about getting the hands dirty with ASP.NET Core MVC framework. Learning about concepts like ");
            EndContext();
            BeginContext(1569, 24, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("my-bold", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb5cdd3c4b1e47948e25ccc0f85daaa9", async() => {
                BeginContext(1578, 5, true);
                WriteLiteral("Model");
                EndContext();
            }
            );
            __DrinkAndGo_TagHelpers_MyBoldTagHelper = CreateTagHelper<global::DrinkAndGo.TagHelpers.MyBoldTagHelper>();
            __tagHelperExecutionContext.Add(__DrinkAndGo_TagHelpers_MyBoldTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1593, 1, true);
            WriteLiteral(",");
            EndContext();
            BeginContext(1594, 29, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("my-bold", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f9bef8ea2cc40ceb7ec9db16ba90461", async() => {
                BeginContext(1603, 10, true);
                WriteLiteral("Controller");
                EndContext();
            }
            );
            __DrinkAndGo_TagHelpers_MyBoldTagHelper = CreateTagHelper<global::DrinkAndGo.TagHelpers.MyBoldTagHelper>();
            __tagHelperExecutionContext.Add(__DrinkAndGo_TagHelpers_MyBoldTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1623, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1625, 23, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("my-bold", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3366e8adeb2463188e52a3d46f542e2", async() => {
                BeginContext(1634, 4, true);
                WriteLiteral("View");
                EndContext();
            }
            );
            __DrinkAndGo_TagHelpers_MyBoldTagHelper = CreateTagHelper<global::DrinkAndGo.TagHelpers.MyBoldTagHelper>();
            __tagHelperExecutionContext.Add(__DrinkAndGo_TagHelpers_MyBoldTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1648, 460, true);
            WriteLiteral(@". The structure of an MVC application.
                The main files and what are the roles of these files on MVC framework. Also there is information about how to configure and use Entity Framework Core Database First in an MVC application. <br />
                For this reason all the code is open source and can be found on <a target=""_blank"" href=""https://github.com/etrupja/DrinkAndGo"">Github</a>
            </p>
        </div>
    </div>
</div>");
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
