#pragma checksum "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\Shift\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd8a19158aa07ea64a18f3db8a385255825e64ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shift_Delete), @"mvc.1.0.view", @"/Views/Shift/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd8a19158aa07ea64a18f3db8a385255825e64ed", @"/Views/Shift/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41d54c6d2223bc95a3875eb8d4309849211c7550", @"/Views/_ViewImports.cshtml")]
    public class Views_Shift_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Asif Shikder\source\repos\EMS\EMS.WEB\Views\Shift\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Delete</h2>");
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
