#pragma checksum "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\SkillMapping\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d757e674802a8be87c13561cf39ea7e45ca6f4a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SkillMapping_Index), @"mvc.1.0.view", @"/Views/SkillMapping/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d757e674802a8be87c13561cf39ea7e45ca6f4a9", @"/Views/SkillMapping/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41d54c6d2223bc95a3875eb8d4309849211c7550", @"/Views/_ViewImports.cshtml")]
    public class Views_SkillMapping_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SkillMappingViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/female.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-thumbnail d-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "SkillMapping", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\SkillMapping\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col my-5"">
            <h1>Skill Mapping</h1>
        </div>
    </div>
</div>

<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-md-6"">
            <div class=""card mb-4"">
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-4"">
");
#nullable restore
#line 22 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\SkillMapping\Index.cshtml"
                             if (String.IsNullOrEmpty(Model.FirstProfileImage))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"profileImage mx-auto my-auto\">\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d757e674802a8be87c13561cf39ea7e45ca6f4a910348", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </div>\n");
#nullable restore
#line 27 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\SkillMapping\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"profileImage mx-auto my-auto\">\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 994, "\"", 1024, 1);
#nullable restore
#line 31 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\SkillMapping\Index.cshtml"
WriteAttributeValue("", 1000, Model.FirstProfileImage, 1000, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail d-block\" />\n                                </div>\n");
#nullable restore
#line 33 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\SkillMapping\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                        <div class=""col-4"">
                            <p>Employee Name:</p>
                            <p>EMployee ID:</p>
                            <p>Job Function</p>
                        </div>
                        <div class=""col-4"">
");
#nullable restore
#line 41 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\SkillMapping\Index.cshtml"
                             if (Model.FirstEmployee != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p>");
#nullable restore
#line 43 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\SkillMapping\Index.cshtml"
                              Write(Model.FirstEmployee.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                <p>");
#nullable restore
#line 44 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\SkillMapping\Index.cshtml"
                              Write(Model.FirstEmployee.EmployeeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                <p>");
#nullable restore
#line 45 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\SkillMapping\Index.cshtml"
                              Write(Model.FirstEmployee.EmployeeState.JobFunction.FunctionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 46 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\SkillMapping\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-md-6"">
            <div class=""card mb-4"">
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-4"">
");
#nullable restore
#line 57 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\SkillMapping\Index.cshtml"
                             if (String.IsNullOrEmpty(Model.SecondProfileImage))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"profileImage mx-auto my-auto\">\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d757e674802a8be87c13561cf39ea7e45ca6f4a915040", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                </div>\n");
#nullable restore
#line 62 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\SkillMapping\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"profileImage mx-auto my-auto\">\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 2623, "\"", 2654, 1);
#nullable restore
#line 66 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\SkillMapping\Index.cshtml"
WriteAttributeValue("", 2629, Model.SecondProfileImage, 2629, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail d-block\" />\n                                </div>\n");
#nullable restore
#line 68 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\SkillMapping\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </div>
                        <div class=""col-4"">
                            <p>Employee Name:</p>
                            <p>EMployee ID:</p>
                            <p>Job Function</p>
                        </div>
                        <div class=""col-4"">
");
#nullable restore
#line 76 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\SkillMapping\Index.cshtml"
                             if (Model.SecondEmployee != null)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <p>");
#nullable restore
#line 78 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\SkillMapping\Index.cshtml"
                              Write(Model.SecondEmployee.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                <p>");
#nullable restore
#line 79 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\SkillMapping\Index.cshtml"
                              Write(Model.SecondEmployee.EmployeeId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n                                <p>");
#nullable restore
#line 80 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\SkillMapping\Index.cshtml"
                              Write(Model.SecondEmployee.EmployeeState.JobFunction.FunctionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 81 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\SkillMapping\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\n                    </div>\n                </div>\n            </div>\n        </div>\n    </div>\n</div>\n\n<div class=\"container-fluid\">\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d757e674802a8be87c13561cf39ea7e45ca6f4a919186", async() => {
                WriteLiteral(@"
        <div class=""form-row"">
            <div class=""col-md-6 mb-4"">
                <div class=""input-group"">
                    <div class=""input-group-prepend w-25"">
                        <label class=""input-group-text"">Employee ID</label>
                    </div>
                    <input type=""text"" name=""firstEmployeeId"" class=""form-control"" placeholder=""Please enter employee ID"">
                </div>
            </div>
            <div class=""col-md-6 mb-4"">
                <div class=""input-group"">
                    <div class=""input-group-prepend w-25"">
                        <label class=""input-group-text"">Employee ID</label>
                    </div>
                    <input type=""text"" name=""secondEmployeeId"" class=""form-control"" placeholder=""Please enter employee ID"">
                </div>
            </div>
            <div class=""col-md-12"">
                <button class=""btn btn-outline-secondary btn-lg btn-block mb-4"" type=""submit"">Check</button>
            </div>
        <");
                WriteLiteral("/div>\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>

<div class=""container-fluid"">

    <div class=""row"">
        <div class=""col-md-6 mb-4"">
            <div class=""card"">
                <div class=""card-header"">
                    <div class=""card-title my-0"">
                        <h5>Matching Skill</h5>
                    </div>
                </div>
                <div class=""card-body"">
                    <div class=""table-responsive"">
                        <table class=""table table-hover table-bordered w-100 mb-0"">
                            <thead class=""thead-light"">
                                <tr>
                                    <th>Skill Name</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>Skill 1</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
   ");
            WriteLiteral(@"     </div>
        <div class=""col-md-6 mb-4"">
            <div class=""card"">
                <div class=""card-header bg-success text-white"">
                    <div class=""card-title my-0"">
                        <h5>Matching Skill</h5>
                    </div>
                </div>
                <div class=""card-body"">
                    <div class=""table-responsive"">
                        <table class=""table table-hover table-bordered w-100 mb-0"">
                            <thead class=""thead-light"">
                                <tr>
                                    <th>Skill Name</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>Skill 1</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>

    ");
            WriteLiteral(@"<div class=""row"">
        <div class=""col-md-6 mb-4"">
            <div class=""card"">
                <div class=""card-header"">
                    <div class=""card-title my-0"">
                        <h5>Not Matching Skill</h5>
                    </div>
                </div>
                <div class=""card-body"">
                    <div class=""table-responsive"">
                        <table class=""table table-hover table-bordered w-100 mb-0"">
                            <thead class=""thead-light"">
                                <tr>
                                    <th>Skill Name</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>Skill 2</td>
                                </tr>
                                <tr>
                                    <td>Skill 2</td>
                                </tr>
                                <tr>
                 ");
            WriteLiteral(@"                   <td>Skill 2</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-md-6 mb-4"">
            <div class=""card"">
                <div class=""card-header bg-danger text-white"">
                    <div class=""card-title my-0"">
                        <h5>Not Matching Skill</h5>
                    </div>
                </div>
                <div class=""card-body"">
                    <div class=""table-responsive"">
                        <table class=""table table-hover table-bordered w-100 mb-0"">
                            <thead class=""thead-light"">
                                <tr>
                                    <th>Skill Name</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>Sk");
            WriteLiteral(@"ill 1</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-md-6 mb-4"">
            <div class=""card"">
                <div class=""card-header"">
                    <div class=""card-title my-0"">
                        <h5>Employee Skill</h5>
                    </div>
                </div>
                <div class=""card-body"">
                    <div class=""table-responsive"">
                        <table class=""table table-hover table-bordered w-100 mb-0"">
                            <thead class=""thead-light"">
                                <tr>
                                    <th>Skill Name</th>
                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>Skill 2</td>
     ");
            WriteLiteral(@"                           </tr>
                                <tr>
                                    <td>Skill 2</td>
                                </tr>
                                <tr>
                                    <td>Skill 2</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-md-6 mb-4"">
            <div class=""card"">
                <div class=""card-header"">
                    <div class=""card-title my-0"">
                        <h5>Employee Skill</h5>
                    </div>
                </div>
                <div class=""card-body"">
                    <div class=""table-responsive"">
                        <table class=""table table-hover table-bordered w-100 mb-0"">
                            <thead class=""thead-light"">
                                <tr>
                                    <th>Skill Name</th>
");
            WriteLiteral(@"                                </tr>
                            </thead>
                            <tbody>
                                <tr>
                                    <td>Skill 1</td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SkillMappingViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
