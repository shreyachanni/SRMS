#pragma checksum "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\Semester\GetSemesters.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "294990ff88db2c42dad18a2ea2876783fab94ae2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Semester_GetSemesters), @"mvc.1.0.view", @"/Views/Semester/GetSemesters.cshtml")]
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
#line 1 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\_ViewImports.cshtml"
using SRM_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\_ViewImports.cshtml"
using SRM_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"294990ff88db2c42dad18a2ea2876783fab94ae2", @"/Views/Semester/GetSemesters.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c9d0494d7102dcb3fb531ed80abc76beb82cc08", @"/Views/_ViewImports.cshtml")]
    public class Views_Semester_GetSemesters : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SRM_MVC.Models.Semester>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\Semester\GetSemesters.cshtml"
  
    ViewData["Title"] = "GetSemesters";
    Layout = "~/Views/Shared/AdminDashBoard.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Semester List</h1>\r\n\r\n");
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\Semester\GetSemesters.cshtml"
           Write(Html.DisplayNameFor(model => model.SemesterId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\Semester\GetSemesters.cshtml"
           Write(Html.DisplayNameFor(model => model.semester));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\Semester\GetSemesters.cshtml"
           Write(Html.DisplayNameFor(model => model.CourseId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 29 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\Semester\GetSemesters.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 32 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\Semester\GetSemesters.cshtml"
           Write(Html.DisplayFor(modelItem => item.SemesterId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 35 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\Semester\GetSemesters.cshtml"
           Write(Html.DisplayFor(modelItem => item.semester));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 38 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\Semester\GetSemesters.cshtml"
           Write(Html.DisplayFor(modelItem => item.CourseId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\Semester\GetSemesters.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 42 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\Semester\GetSemesters.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 43 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\Semester\GetSemesters.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 46 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\Semester\GetSemesters.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SRM_MVC.Models.Semester>> Html { get; private set; }
    }
}
#pragma warning restore 1591