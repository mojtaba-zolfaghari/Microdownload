#pragma checksum "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Views\Shared\_TopBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "635da9f929037a4c14acae1bb7d480b747a286af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TopBar), @"mvc.1.0.view", @"/Views/Shared/_TopBar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_TopBar.cshtml", typeof(AspNetCore.Views_Shared__TopBar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"635da9f929037a4c14acae1bb7d480b747a286af", @"/Views/Shared/_TopBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b31f7f552529ea680838cd1998af403ffbc52b29", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TopBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("top-links"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col_half nobottommargin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("top-social"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col_half fright col_last nobottommargin"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("container clearfix"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("top-bar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 65, true);
            WriteLiteral("<!-- Top Bar\r\n============================================= -->\r\n");
            EndContext();
            BeginContext(65, 2167, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d3d07aa7d71f4222b709d773f2163e01", async() => {
                BeginContext(83, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(91, 2131, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b25bc1f496544b9ea6346683d2236971", async() => {
                    BeginContext(123, 12, true);
                    WriteLiteral("\r\n\r\n        ");
                    EndContext();
                    BeginContext(135, 435, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51141ce81a83464a9dca78092a0a6118", async() => {
                        BeginContext(172, 107, true);
                        WriteLiteral("\r\n\r\n            <!-- Top Links\r\n            ============================================= -->\r\n            ");
                        EndContext();
                        BeginContext(279, 250, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9277365806974b2cb2e8d1c939e074c0", async() => {
                            BeginContext(302, 221, true);
                            WriteLiteral("\r\n                <ul>\r\n                    <li><a href=\"#\">خانه</a></li>\r\n                    <li><a href=\"#\">سوالات متداول</a></li>\r\n                    <li><a href=\"#\">تماس</a></li>\r\n                </ul>\r\n            ");
                            EndContext();
                        }
                        );
                        __Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Microdownload.Areas.Panel.TagHelpers.VisibilityTagHelper>();
                        __tagHelperExecutionContext.Add(__Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper);
                        __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                        await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                        if (!__tagHelperExecutionContext.Output.IsContentModified)
                        {
                            await __tagHelperExecutionContext.SetOutputContentAsync();
                        }
                        Write(__tagHelperExecutionContext.Output);
                        __tagHelperExecutionContext = __tagHelperScopeManager.End();
                        EndContext();
                        BeginContext(529, 35, true);
                        WriteLiteral("<!-- .top-links end -->\r\n\r\n        ");
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
                    BeginContext(570, 12, true);
                    WriteLiteral("\r\n\r\n        ");
                    EndContext();
                    BeginContext(582, 1626, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a50fd9f7956c4893b6cf7f1865b2d042", async() => {
                        BeginContext(635, 108, true);
                        WriteLiteral("\r\n\r\n            <!-- Top Social\r\n            ============================================= -->\r\n            ");
                        EndContext();
                        BeginContext(743, 1423, false);
                        __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3c6b5a02d9fe4e8ca2e3291423efba0c", async() => {
                            BeginContext(764, 1396, true);
                            WriteLiteral(@"
                <ul>
                    <li><a href=""#"" class=""si-facebook""><span class=""ts-icon""><i class=""icon-facebook""></i></span><span class=""ts-text"">Facebook</span></a></li>
                    <li><a href=""#"" class=""si-twitter""><span class=""ts-icon""><i class=""icon-twitter""></i></span><span class=""ts-text"">Twitter</span></a></li>
                    <li><a href=""#"" class=""si-dribbble""><span class=""ts-icon""><i class=""icon-dribbble""></i></span><span class=""ts-text"">Dribbble</span></a></li>
                    <li><a href=""#"" class=""si-github""><span class=""ts-icon""><i class=""icon-github-circled""></i></span><span class=""ts-text"">Github</span></a></li>
                    <li><a href=""#"" class=""si-pinterest""><span class=""ts-icon""><i class=""icon-pinterest""></i></span><span class=""ts-text"">Pinterest</span></a></li>
                    <li><a href=""#"" class=""si-instagram""><span class=""ts-icon""><i class=""icon-instagram2""></i></span><span class=""ts-text"">Instagram</span></a></li>
                    <l");
                            WriteLiteral(@"i><a href=""tel:+982177571436"" class=""si-call""><span class=""ts-icon""><i class=""icon-call""></i></span><span class=""ts-text"">۰۲۱۷۷۵۷۱۴۳۶</span></a></li>
                    <li><a href=""mailto:info@Katebb.com"" class=""si-email3""><span class=""ts-icon""><i class=""icon-email3""></i></span><span class=""ts-text"">info@Katebb.com</span></a></li>
                </ul>
            ");
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
                        BeginContext(2166, 36, true);
                        WriteLiteral("<!-- #top-social end -->\r\n\r\n        ");
                        EndContext();
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
                    BeginContext(2208, 8, true);
                    WriteLiteral("\r\n\r\n    ");
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
                BeginContext(2222, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Microdownload.Areas.Panel.TagHelpers.VisibilityTagHelper>();
            __tagHelperExecutionContext.Add(__Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2232, 23, true);
            WriteLiteral("<!-- #top-bar end -->\r\n");
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
