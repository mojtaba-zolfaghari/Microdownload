#pragma checksum "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Views\Shared\_SidebarMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ecd1231776016d79be150472762f08a9a391ef5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__SidebarMenu), @"mvc.1.0.view", @"/Views/Shared/_SidebarMenu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_SidebarMenu.cshtml", typeof(AspNetCore.Views_Shared__SidebarMenu))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ecd1231776016d79be150472762f08a9a391ef5", @"/Views/Shared/_SidebarMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b31f7f552529ea680838cd1998af403ffbc52b29", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__SidebarMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private global::AspNetCore.Views_Shared__SidebarMenu.__Generated__OnlineUsersViewComponentTagHelper __OnlineUsersViewComponentTagHelper;
        private global::AspNetCore.Views_Shared__SidebarMenu.__Generated__TodayBirthDaysViewComponentTagHelper __TodayBirthDaysViewComponentTagHelper;
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("OnlineUsers"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("dir", new global::Microsoft.AspNetCore.Html.HtmlString("rtl"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("TodayBirthDays"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.CacheTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 217, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49e298a88e1e4e82a76cbb29ba3e1f62", async() => {
                BeginContext(32, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(37, 173, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("cache", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd9312cd5d984c32baab81519eb8eede", async() => {
                    BeginContext(85, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(94, 103, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:online-users", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "40747c8e11ea4bf48384c654c168be28", async() => {
                    }
                    );
                    __OnlineUsersViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Shared__SidebarMenu.__Generated__OnlineUsersViewComponentTagHelper>();
                    __tagHelperExecutionContext.Add(__OnlineUsersViewComponentTagHelper);
#line 3 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Views\Shared\_SidebarMenu.cshtml"
__OnlineUsersViewComponentTagHelper.numbersToTake = 5;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("numbers-to-take", __OnlineUsersViewComponentTagHelper.numbersToTake, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 3 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Views\Shared\_SidebarMenu.cshtml"
__OnlineUsersViewComponentTagHelper.minutesToTake = 5;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("minutes-to-take", __OnlineUsersViewComponentTagHelper.minutesToTake, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 3 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Views\Shared\_SidebarMenu.cshtml"
__OnlineUsersViewComponentTagHelper.showMoreItemsLink = true;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("show-more-items-link", __OnlineUsersViewComponentTagHelper.showMoreItemsLink, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(197, 5, true);
                    WriteLiteral("\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.CacheTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper);
#line 2 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Views\Shared\_SidebarMenu.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper.ExpiresAfter = TimeSpan.FromMinutes(1);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("expires-after", __Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper.ExpiresAfter, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(210, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Microdownload.Areas.Panel.TagHelpers.VisibilityTagHelper>();
            __tagHelperExecutionContext.Add(__Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(217, 2, true);
            WriteLiteral("\n\n");
            EndContext();
            BeginContext(219, 160, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "deba68f3c89c4ff08416169f2c97d4e9", async() => {
                BeginContext(254, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(259, 113, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("cache", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4a3ec13728d4fd5a0eae53d7f05e527", async() => {
                    BeginContext(307, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(316, 43, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("vc:today-birth-days", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feb88402823746eb88a2cb0d81f89e22", async() => {
                    }
                    );
                    __TodayBirthDaysViewComponentTagHelper = CreateTagHelper<global::AspNetCore.Views_Shared__SidebarMenu.__Generated__TodayBirthDaysViewComponentTagHelper>();
                    __tagHelperExecutionContext.Add(__TodayBirthDaysViewComponentTagHelper);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(359, 5, true);
                    WriteLiteral("\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.CacheTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper);
#line 8 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Views\Shared\_SidebarMenu.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper.ExpiresAfter = TimeSpan.FromMinutes(5);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("expires-after", __Microsoft_AspNetCore_Mvc_TagHelpers_CacheTagHelper.ExpiresAfter, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(372, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            __Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper = CreateTagHelper<global::Microdownload.Areas.Panel.TagHelpers.VisibilityTagHelper>();
            __tagHelperExecutionContext.Add(__Microdownload_Areas_Panel_TagHelpers_VisibilityTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:online-users")]
        public class __Generated__OnlineUsersViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper _helper = null;
            public __Generated__OnlineUsersViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                _helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public System.Int32 numbersToTake { get; set; }
            public System.Int32 minutesToTake { get; set; }
            public System.Boolean showMoreItemsLink { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output)
            {
                (_helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var content = await _helper.InvokeAsync("OnlineUsers", new { numbersToTake, minutesToTake, showMoreItemsLink });
                output.TagName = null;
                output.Content.SetHtmlContent(content);
            }
        }
        [Microsoft.AspNetCore.Razor.TagHelpers.HtmlTargetElementAttribute("vc:today-birth-days")]
        public class __Generated__TodayBirthDaysViewComponentTagHelper : Microsoft.AspNetCore.Razor.TagHelpers.TagHelper
        {
            private readonly global::Microsoft.AspNetCore.Mvc.IViewComponentHelper _helper = null;
            public __Generated__TodayBirthDaysViewComponentTagHelper(global::Microsoft.AspNetCore.Mvc.IViewComponentHelper helper)
            {
                _helper = helper;
            }
            [Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeNotBoundAttribute, global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewContextAttribute]
            public global::Microsoft.AspNetCore.Mvc.Rendering.ViewContext ViewContext { get; set; }
            public override async global::System.Threading.Tasks.Task ProcessAsync(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext context, Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput output)
            {
                (_helper as global::Microsoft.AspNetCore.Mvc.ViewFeatures.IViewContextAware)?.Contextualize(ViewContext);
                var content = await _helper.InvokeAsync("TodayBirthDays", new {  });
                output.TagName = null;
                output.Content.SetHtmlContent(content);
            }
        }
    }
}
#pragma warning restore 1591
