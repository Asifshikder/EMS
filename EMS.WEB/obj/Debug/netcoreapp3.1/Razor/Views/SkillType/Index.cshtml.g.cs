#pragma checksum "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\SkillType\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "786be3269627860d25a13a6777a9dc80910b77fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SkillType_Index), @"mvc.1.0.view", @"/Views/SkillType/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\_ViewImports.cshtml"
using EMS.WebCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\_ViewImports.cshtml"
using EMS.WebCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\_ViewImports.cshtml"
using EMS.WebCore.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\_ViewImports.cshtml"
using EMS.WebCore.ViewModels.Department;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\_ViewImports.cshtml"
using EMS.WebCore.ViewModels.Section;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\_ViewImports.cshtml"
using EMS.WebCore.ViewModels.Employee;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\_ViewImports.cshtml"
using EMS.WebCore.ViewModels.EmployeeSkill;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\_ViewImports.cshtml"
using EMS.WebCore.ViewModels.Attendance;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\_ViewImports.cshtml"
using EMS.WebCore.ViewModels.JobPosition;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\_ViewImports.cshtml"
using EMS.WebCore.ViewModels.JobFunction;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\_ViewImports.cshtml"
using EMS.WebCore.ViewModels.Level;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\_ViewImports.cshtml"
using EMS.WebCore.ViewModels.BusStation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\_ViewImports.cshtml"
using EMS.WebCore.ViewModels.Route;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\_ViewImports.cshtml"
using EMS.WebCore.ViewModels.Shift;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\_ViewImports.cshtml"
using EMS.WebCore.ViewModels.ShiftCalendar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\_ViewImports.cshtml"
using EMS.WebCore.ViewModels.Profile;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\_ViewImports.cshtml"
using EMS.WebCore.ViewModels.Dashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\_ViewImports.cshtml"
using EMS.WebCore.ViewModels.Degree;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\_ViewImports.cshtml"
using EMS.WebCore.ViewModels.Major;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\_ViewImports.cshtml"
using EMS.WebCore.ViewModels.Skill;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\_ViewImports.cshtml"
using EMS.WebCore.ViewModels.SkillGroup;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\_ViewImports.cshtml"
using EMS.WebCore.ViewModels.SkillType;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\_ViewImports.cshtml"
using EMS.WebCore.ViewModels.SkillMapping;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\_ViewImports.cshtml"
using EMS.ApplicationCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"786be3269627860d25a13a6777a9dc80910b77fa", @"/Views/SkillType/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41d54c6d2223bc95a3875eb8d4309849211c7550", @"/Views/_ViewImports.cshtml")]
    public class Views_SkillType_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SkillTypeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "BusStation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\SkillType\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""d-flex justify-content-between flex-wrap flex-md-nowrap align-items-center pt-3 pb-2 mb-3"">
        <h1 class=""h2"">Skill Type Configuration</h1>
        <div class=""btn-toolbar mb-2 mb-md-0"">
            <div class=""btn-group mr-2"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "786be3269627860d25a13a6777a9dc80910b77fa10174", async() => {
                WriteLiteral("Create");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </div>\n        </div>\n    </div>\n</div>\n\n<div class=\"container-fluid\">\n    <div class=\"row\">\n        <div class=\"col\">\n");
#nullable restore
#line 21 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\SkillType\Index.cshtml"
             if (Model.SkillTypes.Any())
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <table class=""table table-striped table-bordered table-hover"">
                    <thead>
                        <tr>
                            <th>#</th>
                            <th>Skill Type</th>
                            <th>Action</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 32 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\SkillType\Index.cshtml"
                         foreach (var item in Model.SkillTypes)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\n                                <td>");
#nullable restore
#line 36 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\SkillType\Index.cshtml"
                               Write(item.SkillTypeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>");
#nullable restore
#line 37 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\SkillType\Index.cshtml"
                               Write(item.SkillTypeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                <td>\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "786be3269627860d25a13a6777a9dc80910b77fa13121", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\SkillType\Index.cshtml"
                                                                                       WriteLiteral(item.SkillTypeId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "786be3269627860d25a13a6777a9dc80910b77fa15645", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 40 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\SkillType\Index.cshtml"
                                                                                         WriteLiteral(item.SkillTypeId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </td>\n                            </tr>\n");
#nullable restore
#line 43 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\SkillType\Index.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\n                </table>\n");
#nullable restore
#line 47 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\SkillType\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SkillTypeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
