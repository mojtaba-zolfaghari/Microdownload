#pragma checksum "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\RolesManager\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "423d17bb5eb9bcaab3db4e53ffc7f9e7f416ec41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Panel_Views_RolesManager_Index), @"mvc.1.0.view", @"/Areas/Panel/Views/RolesManager/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Panel/Views/RolesManager/Index.cshtml", typeof(AspNetCore.Areas_Panel_Views_RolesManager_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
#line 13 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using System.Threading.Tasks;

#line default
#line hidden
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microdownload.Areas.Panel;

#line default
#line hidden
#line 2 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microdownload.Common.IdentityToolkit;

#line default
#line hidden
#line 3 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microdownload.Common.PersianToolkit;

#line default
#line hidden
#line 4 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microdownload.Entities.Identity;

#line default
#line hidden
#line 5 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microdownload.Services.Contracts.Identity;

#line default
#line hidden
#line 6 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microdownload.Services.Identity;

#line default
#line hidden
#line 7 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microdownload.ViewModels.Identity;

#line default
#line hidden
#line 8 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microdownload.ViewModels.Identity.Emails;

#line default
#line hidden
#line 9 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microdownload.ViewModels.Identity.Settings;

#line default
#line hidden
#line 10 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#line 11 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#line 12 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#line 14 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using System.Net;

#line default
#line hidden
#line 15 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using DNTPersianUtils.Core;

#line default
#line hidden
#line 16 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microdownload.DataLayer.Context;

#line default
#line hidden
#line 17 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microdownload.Entities.AuditableEntity;

#line default
#line hidden
#line 18 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using NonFactors.Mvc.Grid;

#line default
#line hidden
#line 19 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microdownload.ViewModels;

#line default
#line hidden
#line 20 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microdownload.Common.WebToolkit;

#line default
#line hidden
#line 21 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\_ViewImports.cshtml"
using Microdownload.Entities;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"423d17bb5eb9bcaab3db4e53ffc7f9e7f416ec41", @"/Areas/Panel/Views/RolesManager/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbc03c310595be153c47e0111723af51088497e6", @"/Areas/Panel/Views/_ViewImports.cshtml")]
    public class Areas_Panel_Views_RolesManager_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RoleAndUsersCountViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("alert alert-warning top30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("panel-heading"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AllRolesList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("panel-body"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("panel panel-default top30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\RolesManager\Index.cshtml"
  
    ViewData["Title"] = "مدیریت نقش‌های سیستم";

#line default
#line hidden
            BeginContext(106, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(108, 1484, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df82780a9aa64adf960b9b7545a418bd", async() => {
                BeginContext(147, 1439, true);
                WriteLiteral(@"
    <a href=""#"" class=""close"" data-dismiss=""alert"">×</a>
    <ul>
        <li>
            ویرایش نام نقش‌های ثابت سیستم و یا حذف آن‌ها می‌تواند دسترسی به قسمت‌های از پیش طراحی شده‌ی برنامه را از کار بیندازد
            <span dir=""ltr"">.([Authorize(Roles = ConstantRoles.Admin)])</span>
            بنابراین هرگونه تغییری در اینجا نیاز است در کدهای برنامه نیز منعکس شود و یا برعکس.
        </li>
        <li>
            در اینجا می‌توان به هر نقش ثابت، دسترسی‌های پویایی را نیز اعطاء کرد. در این حالت کنترلر و یا اکشن متدهایی با پالیسی سطوح دسترسی پویا، لیست شده و قابل انتخاب خواهند بود
            <span dir=""ltr"">.([Authorize(Policy = ConstantPolicies.DynamicPermission)])</span>
        </li>
        <li>
            در حالت استفاده‌ی از سطوح دسترسی پویا، با تغییر نام و یا حذف نقش‌های ثابت، نیازی به تغییری در کدهای برنامه نخواهد بود.
        </li>
        <li>تمام نمایندگان منتسب به نقش Admin، به صفحات دارای سطوح دسترسی پویا نیز دسترسی کاملی دارند و نیازی به افزودن آن‌ها به لیست نفرات این نوع نقش‌");
                WriteLiteral(@"های پویای خاص نیست.</li>
        <li>اگر در یک فیلتر Authorize، نقش جدیدی را بکار گرفته‌اید، می‌توانید آن‌را در اینجا اضافه کنید.</li>
        <li>اگر نام نقش بکار رفته‌ی در فیلترهای Authorize را تغییر داده‌اید، می‌توانید این تغییرات را نیز در اینجا اعمال و ویرایش نمائید.</li>
        <li>اگر از فیلترهای Authorize، نقشی را به طور کامل حذف کرده‌اید، می‌توانید این نقش را در اینجا نیز حذف کنید.</li>
    </ul>
");
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
            BeginContext(1592, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(1596, 379, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d824437ea5a24df9baa224d7a5c39d52", async() => {
                BeginContext(1635, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1641, 96, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b025696a9b20432fbe51a5313ed4cd72", async() => {
                    BeginContext(1668, 34, true);
                    WriteLiteral("\r\n        <h3 class=\"panel-title\">");
                    EndContext();
                    BeginContext(1703, 17, false);
#line 31 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\RolesManager\Index.cshtml"
                           Write(ViewData["Title"]);

#line default
#line hidden
                    EndContext();
                    BeginContext(1720, 11, true);
                    WriteLiteral("</h3>\r\n    ");
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
                BeginContext(1737, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(1743, 92, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90d45f5fa7f94876a6d0d5cac88a3022", async() => {
                    BeginContext(1767, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(1777, 46, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "04f06b1979b54f36af6d0a3b620444df", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 34 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\RolesManager\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(1823, 6, true);
                    WriteLiteral("\r\n    ");
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
                BeginContext(1835, 134, true);
                WriteLiteral("\r\n    <footer class=\"panel-footer\">\r\n        <a class=\"btn btn-success\" href=\"#\" id=\"btnCreate\">ایجاد یک نقش جدید</a>\r\n    </footer>\r\n");
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
            BeginContext(1975, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(1998, 267, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(function () {
            $('#btnCreate').click(function (e) {
                e.preventDefault(); //می‌خواهیم لینک به صورت معمول عمل نکند

                $.bootstrapModalAjaxForm({
                    postUrl: '");
                EndContext();
                BeginContext(2266, 37, false);
#line 49 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\RolesManager\Index.cshtml"
                         Write(Url.Action("AddRole", "RolesManager"));

#line default
#line hidden
                EndContext();
                BeginContext(2303, 52, true);
                WriteLiteral("\',\r\n                    renderModalPartialViewUrl: \'");
                EndContext();
                BeginContext(2356, 40, false);
#line 50 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\RolesManager\Index.cshtml"
                                           Write(Url.Action("RenderRole", "RolesManager"));

#line default
#line hidden
                EndContext();
                BeginContext(2396, 681, true);
                WriteLiteral(@"',
                    renderModalPartialViewData: {},
                    loginUrl: '/identity/login',
                    beforePostHandler: function () {
                    },
                    completeHandler: function () {
                        location.reload();
                    },
                    errorHandler: function () {
                    }
                });
            });

            $(""a[id^='btnEdit']"").click(function (e) {
                e.preventDefault(); //می‌خواهیم لینک به صورت معمول عمل نکند
                var roleId = $(this).data(""edit-id"");

                $.bootstrapModalAjaxForm({
                    postUrl: '");
                EndContext();
                BeginContext(3078, 38, false);
#line 68 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\RolesManager\Index.cshtml"
                         Write(Url.Action("EditRole", "RolesManager"));

#line default
#line hidden
                EndContext();
                BeginContext(3116, 52, true);
                WriteLiteral("\',\r\n                    renderModalPartialViewUrl: \'");
                EndContext();
                BeginContext(3169, 40, false);
#line 69 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\RolesManager\Index.cshtml"
                                           Write(Url.Action("RenderRole", "RolesManager"));

#line default
#line hidden
                EndContext();
                BeginContext(3209, 715, true);
                WriteLiteral(@"',
                    renderModalPartialViewData: JSON.stringify({ ""id"": roleId }),
                    loginUrl: '/identity/login',
                    beforePostHandler: function () {
                    },
                    completeHandler: function () {
                        location.reload();
                    },
                    errorHandler: function () {
                    }
                });
            });

            $(""a[id^='btnDelete']"").click(function (e) {
                e.preventDefault(); //می‌خواهیم لینک به صورت معمول عمل نکند
                var roleId = $(this).data(""delete-id"");

                $.bootstrapModalAjaxForm({
                    postUrl: '");
                EndContext();
                BeginContext(3925, 36, false);
#line 87 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\RolesManager\Index.cshtml"
                         Write(Url.Action("Delete", "RolesManager"));

#line default
#line hidden
                EndContext();
                BeginContext(3961, 52, true);
                WriteLiteral("\',\r\n                    renderModalPartialViewUrl: \'");
                EndContext();
                BeginContext(4014, 46, false);
#line 88 "D:\Projects\Milad\Solution\Microdownload\src\Microdownload\Areas\Panel\Views\RolesManager\Index.cshtml"
                                           Write(Url.Action("RenderDeleteRole", "RolesManager"));

#line default
#line hidden
                EndContext();
                BeginContext(4060, 473, true);
                WriteLiteral(@"',
                    renderModalPartialViewData: JSON.stringify({ ""id"": roleId }),
                    loginUrl: '/identity/login',
                    beforePostHandler: function () {
                    },
                    completeHandler: function () {
                        location.reload();
                    },
                    errorHandler: function () {
                    }
                });
            });
        });
    </script>
");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RoleAndUsersCountViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
