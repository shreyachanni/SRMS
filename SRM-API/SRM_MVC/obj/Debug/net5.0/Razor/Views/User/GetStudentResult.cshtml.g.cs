#pragma checksum "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\User\GetStudentResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "835aeac217f50f7739aad7eb6f6645fdfdf02993"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_GetStudentResult), @"mvc.1.0.view", @"/Views/User/GetStudentResult.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"835aeac217f50f7739aad7eb6f6645fdfdf02993", @"/Views/User/GetStudentResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c9d0494d7102dcb3fb531ed80abc76beb82cc08", @"/Views/_ViewImports.cshtml")]
    public class Views_User_GetStudentResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SRM_MVC.Models.Result>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Student", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "GetStudentResult", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\User\GetStudentResult.cshtml"
  
    ViewData["Title"] = "GetStudentResult";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <h1>Student Result</h1>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "835aeac217f50f7739aad7eb6f6645fdfdf029934368", async() => {
                WriteLiteral("\r\n            <label>Student ID</label>\r\n            <input name=\"id\" />\r\n\r\n            <div class=\"form-group\">\r\n                ");
#nullable restore
#line 13 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\User\GetStudentResult.cshtml"
           Write(Html.LabelFor(model => model.SemesterId, "Semid", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                <div class=\"col-md-5\">\r\n                    ");
#nullable restore
#line 15 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\User\GetStudentResult.cshtml"
               Write(Html.DropDownListFor(x => Model.SemesterId, new SelectList(ViewBag.semLiIst, "Value", "Text"), htmlAttributes: new { @class = "form-control", id = "Country" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    ");
#nullable restore
#line 16 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\User\GetStudentResult.cshtml"
               Write(Html.ValidationMessageFor(model => model.SemesterId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <button value=\"Submit\" type=\"submit\" class=\"btn btn-primary\">Result</button>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n  \r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SRM_MVC.Models.Result> Html { get; private set; }
    }
}
#pragma warning restore 1591
