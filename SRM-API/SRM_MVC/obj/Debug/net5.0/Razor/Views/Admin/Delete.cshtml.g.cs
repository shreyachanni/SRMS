#pragma checksum "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\Admin\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83216fb683314696e00721abe7413af45a8f950a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Delete), @"mvc.1.0.view", @"/Views/Admin/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83216fb683314696e00721abe7413af45a8f950a", @"/Views/Admin/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c9d0494d7102dcb3fb531ed80abc76beb82cc08", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SRM_MVC.Models.Admin>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\Admin\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/AdminDashBoard.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    \r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\Admin\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AdminId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\Admin\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AdminId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\Admin\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AdminFirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\Admin\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AdminFirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\Admin\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AdminLastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\Admin\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AdminLastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\Admin\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AdminEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\Admin\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AdminEmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\Admin\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AdminGender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\Admin\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AdminGender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\Admin\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AdminCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\Admin\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AdminCity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\Admin\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.AdminPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\Admin\Delete.cshtml"
       Write(Html.DisplayFor(model => model.AdminPassword));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83216fb683314696e00721abe7413af45a8f950a10189", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "83216fb683314696e00721abe7413af45a8f950a10456", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 60 "C:\Users\shrey\Downloads\SRM-API-Dileep_Update\SRM-API-Dileep3301021\SRM-API-Dileep3301021\SRM-API\SRM_MVC\Views\Admin\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.AdminId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" />\r\n");
                WriteLiteral("    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SRM_MVC.Models.Admin> Html { get; private set; }
    }
}
#pragma warning restore 1591
