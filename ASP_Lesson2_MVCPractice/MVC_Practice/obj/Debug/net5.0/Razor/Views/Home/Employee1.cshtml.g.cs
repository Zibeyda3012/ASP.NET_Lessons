#pragma checksum "C:\Users\Zibeyde\Desktop\ASP.NET_Lessons\ASP_Lesson2_MVCPractice\MVC_Practice\Views\Home\Employee1.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "bf72d6c7d83bbcf9ba992018cde061254eb0ff82a014032ac19208de14acbaeb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Employee1), @"mvc.1.0.view", @"/Views/Home/Employee1.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
    #line default
    #line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"bf72d6c7d83bbcf9ba992018cde061254eb0ff82a014032ac19208de14acbaeb", @"/Views/Home/Employee1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6527b91c79defe613cf45f20aa8ec1bf663d068c0357de1cf60eb12f8d476001", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Employee1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MVC_Practice.Entities.Employee>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Zibeyde\Desktop\ASP.NET_Lessons\ASP_Lesson2_MVCPractice\MVC_Practice\Views\Home\Employee1.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf72d6c7d83bbcf9ba992018cde061254eb0ff82a014032ac19208de14acbaeb3853", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Employee1</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf72d6c7d83bbcf9ba992018cde061254eb0ff82a014032ac19208de14acbaeb4940", async() => {
                WriteLiteral("\r\n<p>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf72d6c7d83bbcf9ba992018cde061254eb0ff82a014032ac19208de14acbaeb5233", async() => {
                    WriteLiteral("Create New");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
                Write(
#nullable restore
#line 22 "C:\Users\Zibeyde\Desktop\ASP.NET_Lessons\ASP_Lesson2_MVCPractice\MVC_Practice\Views\Home\Employee1.cshtml"
                 Html.DisplayNameFor(model => model.Id)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                Write(
#nullable restore
#line 25 "C:\Users\Zibeyde\Desktop\ASP.NET_Lessons\ASP_Lesson2_MVCPractice\MVC_Practice\Views\Home\Employee1.cshtml"
                 Html.DisplayNameFor(model => model.CityId)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                Write(
#nullable restore
#line 28 "C:\Users\Zibeyde\Desktop\ASP.NET_Lessons\ASP_Lesson2_MVCPractice\MVC_Practice\Views\Home\Employee1.cshtml"
                 Html.DisplayNameFor(model => model.Firstname)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
                Write(
#nullable restore
#line 31 "C:\Users\Zibeyde\Desktop\ASP.NET_Lessons\ASP_Lesson2_MVCPractice\MVC_Practice\Views\Home\Employee1.cshtml"
                 Html.DisplayNameFor(model => model.Lastname)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 37 "C:\Users\Zibeyde\Desktop\ASP.NET_Lessons\ASP_Lesson2_MVCPractice\MVC_Practice\Views\Home\Employee1.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable

                WriteLiteral("        <tr>\r\n            <td>\r\n                ");
                Write(
#nullable restore
#line 40 "C:\Users\Zibeyde\Desktop\ASP.NET_Lessons\ASP_Lesson2_MVCPractice\MVC_Practice\Views\Home\Employee1.cshtml"
                 Html.DisplayFor(modelItem => item.Id)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                Write(
#nullable restore
#line 43 "C:\Users\Zibeyde\Desktop\ASP.NET_Lessons\ASP_Lesson2_MVCPractice\MVC_Practice\Views\Home\Employee1.cshtml"
                 Html.DisplayFor(modelItem => item.CityId)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                Write(
#nullable restore
#line 46 "C:\Users\Zibeyde\Desktop\ASP.NET_Lessons\ASP_Lesson2_MVCPractice\MVC_Practice\Views\Home\Employee1.cshtml"
                 Html.DisplayFor(modelItem => item.Firstname)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                Write(
#nullable restore
#line 49 "C:\Users\Zibeyde\Desktop\ASP.NET_Lessons\ASP_Lesson2_MVCPractice\MVC_Practice\Views\Home\Employee1.cshtml"
                 Html.DisplayFor(modelItem => item.Lastname)

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
                Write(
#nullable restore
#line 52 "C:\Users\Zibeyde\Desktop\ASP.NET_Lessons\ASP_Lesson2_MVCPractice\MVC_Practice\Views\Home\Employee1.cshtml"
                 Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(" |\r\n                ");
                Write(
#nullable restore
#line 53 "C:\Users\Zibeyde\Desktop\ASP.NET_Lessons\ASP_Lesson2_MVCPractice\MVC_Practice\Views\Home\Employee1.cshtml"
                 Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(" |\r\n                ");
                Write(
#nullable restore
#line 54 "C:\Users\Zibeyde\Desktop\ASP.NET_Lessons\ASP_Lesson2_MVCPractice\MVC_Practice\Views\Home\Employee1.cshtml"
                 Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ })

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 57 "C:\Users\Zibeyde\Desktop\ASP.NET_Lessons\ASP_Lesson2_MVCPractice\MVC_Practice\Views\Home\Employee1.cshtml"
}

#line default
#line hidden
#nullable disable

                WriteLiteral("    </tbody>\r\n</table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MVC_Practice.Entities.Employee>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
