#pragma checksum "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Views\Club\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9aa44fd154793ca6e9c39bbc9b420b24854938b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Club_Index), @"mvc.1.0.view", @"/Views/Club/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Club/Index.cshtml", typeof(AspNetCore.Views_Club_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
#line 12 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Views\_ViewImports.cshtml"
using System.Threading.Tasks;

#line default
#line hidden
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Views\_ViewImports.cshtml"
using Microdownload.Areas.Panel;

#line default
#line hidden
#line 2 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Views\_ViewImports.cshtml"
using Microdownload.Common.IdentityToolkit;

#line default
#line hidden
#line 3 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Views\_ViewImports.cshtml"
using Microdownload.Common.PersianToolkit;

#line default
#line hidden
#line 4 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Views\_ViewImports.cshtml"
using Microdownload.Entities.Identity;

#line default
#line hidden
#line 5 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Views\_ViewImports.cshtml"
using Microdownload.Services.Contracts.Identity;

#line default
#line hidden
#line 6 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Views\_ViewImports.cshtml"
using Microdownload.Services.Identity;

#line default
#line hidden
#line 7 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Views\_ViewImports.cshtml"
using Microdownload.ViewModels.Identity;

#line default
#line hidden
#line 8 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Views\_ViewImports.cshtml"
using Microdownload.ViewModels.Identity.Settings;

#line default
#line hidden
#line 9 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#line 10 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#line 11 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#line 13 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Views\_ViewImports.cshtml"
using System.Net;

#line default
#line hidden
#line 14 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Views\_ViewImports.cshtml"
using DNTPersianUtils.Core;

#line default
#line hidden
#line 15 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Views\_ViewImports.cshtml"
using Microdownload.DataLayer.Context;

#line default
#line hidden
#line 16 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Views\_ViewImports.cshtml"
using Microdownload.Entities.AuditableEntity;

#line default
#line hidden
#line 17 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Views\_ViewImports.cshtml"
using Microdownload.ViewModels;

#line default
#line hidden
#line 18 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Views\_ViewImports.cshtml"
using Microdownload.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9aa44fd154793ca6e9c39bbc9b420b24854938b3", @"/Views/Club/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b31f7f552529ea680838cd1998af403ffbc52b29", @"/Views/_ViewImports.cshtml")]
    public class Views_Club_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("container clearfix"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("fancy-title title-border"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("clear"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("content-wrap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microdownload.Areas.Panel.TagHelpers.VisibilityTagHelper __Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Views\Club\Index.cshtml"
  
    ViewData["Title"] = "باشگاه مشتریان";

#line default
#line hidden
            BeginContext(52, 103, true);
            WriteLiteral("\r\n<!-- Page Title\r\n============================================= -->\r\n<section id=\"page-title\">\r\n\r\n    ");
            EndContext();
            BeginContext(155, 316, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad044aac525749ebb05d752f637d761e", async() => {
                BeginContext(187, 14, true);
                WriteLiteral("\r\n        <h1>");
                EndContext();
                BeginContext(202, 17, false);
#line 11 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Views\Club\Index.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(219, 103, true);
                WriteLiteral("</h1>\r\n        <span></span>\r\n        <ol class=\"breadcrumb\">\r\n            <li class=\"breadcrumb-item\">");
                EndContext();
                BeginContext(322, 21, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "29b337e8a6fa44a1b013219beacbd31b", async() => {
                    BeginContext(335, 4, true);
                    WriteLiteral("خانه");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(343, 74, true);
                WriteLiteral("</li>\r\n            <li class=\"breadcrumb-item active\" aria-current=\"page\">");
                EndContext();
                BeginContext(418, 17, false);
#line 15 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Views\Club\Index.cshtml"
                                                              Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(435, 30, true);
                WriteLiteral("</li>\r\n        </ol>\r\n\r\n\r\n    ");
                EndContext();
            }
            );
            __Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Microdownload.Areas.Panel.TagHelpers.VisibilityTagHelper>();
            __tagHelperExecutionContext.Add(__Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(471, 72, true);
            WriteLiteral("\r\n\r\n</section><!-- #page-title end -->\r\n\r\n<section id=\"content\">\r\n\r\n    ");
            EndContext();
            BeginContext(543, 332, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8b2739b1afb74611893b05c9c6ed5d4a", async() => {
                BeginContext(569, 12, true);
                WriteLiteral("\r\n\r\n        ");
                EndContext();
                BeginContext(581, 237, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19ed212bd7f84130abf93172bd6ce2fa", async() => {
                    BeginContext(613, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(627, 103, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "977c4315ec284d3fb9e9ef60105e6743", async() => {
                        BeginContext(665, 22, true);
                        WriteLiteral("\r\n                <h3>");
                        EndContext();
                        BeginContext(688, 17, false);
#line 29 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Views\Club\Index.cshtml"
               Write(ViewData["Title"]);

#line default
#line hidden
                        EndContext();
                        BeginContext(705, 19, true);
                        WriteLiteral("</h3>\r\n            ");
                        EndContext();
                    }
                    );
                    __Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Microdownload.Areas.Panel.TagHelpers.VisibilityTagHelper>();
                    __tagHelperExecutionContext.Add(__Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(730, 14, true);
                    WriteLiteral("\r\n            ");
                    EndContext();
                    BeginContext(744, 56, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "45829aaa2260495090432b22c653905a", async() => {
                        BeginContext(749, 45, true);
                        WriteLiteral("\r\n\r\n              به زودی ...\r\n\r\n            ");
                        EndContext();
                    }
                    );
                    __Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Microdownload.Areas.Panel.TagHelpers.VisibilityTagHelper>();
                    __tagHelperExecutionContext.Add(__Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(800, 12, true);
                    WriteLiteral("\r\n\r\n        ");
                    EndContext();
                }
                );
                __Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Microdownload.Areas.Panel.TagHelpers.VisibilityTagHelper>();
                __tagHelperExecutionContext.Add(__Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(818, 12, true);
                WriteLiteral("\r\n\r\n        ");
                EndContext();
                BeginContext(830, 25, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "779096a3a8d2402c9dfda2bae5cb87ad", async() => {
                }
                );
                __Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Microdownload.Areas.Panel.TagHelpers.VisibilityTagHelper>();
                __tagHelperExecutionContext.Add(__Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(855, 14, true);
                WriteLiteral("\r\n\r\n\r\n\r\n\r\n    ");
                EndContext();
            }
            );
            __Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Microdownload.Areas.Panel.TagHelpers.VisibilityTagHelper>();
            __tagHelperExecutionContext.Add(__Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(875, 39, true);
            WriteLiteral("\r\n\r\n\r\n</section><!-- #content end -->\r\n");
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
