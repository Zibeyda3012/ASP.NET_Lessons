#pragma checksum "C:\Users\Musay_zv97\Desktop\ASP.NET\ASP_Lesson2_MVCPractice\MVC_Practice\Views\Home\Employee2.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "410c599e7822041f042d99b3d6a12dd9e5b88f0a93c7fbbe9bd1a77ff16895f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Employee2), @"mvc.1.0.view", @"/Views/Home/Employee2.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Musay_zv97\Desktop\ASP.NET\ASP_Lesson2_MVCPractice\MVC_Practice\Views\_ViewImports.cshtml"
using MVC_Practice;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"410c599e7822041f042d99b3d6a12dd9e5b88f0a93c7fbbe9bd1a77ff16895f4", @"/Views/Home/Employee2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"f659d8eea156b5fcfd6c3dd8cf9d4e45afb7d1978c232b4044802c98fd56c846", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Employee2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MVC_Practice.Models.EmployeeViewModel>
    #nullable disable
    {
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "410c599e7822041f042d99b3d6a12dd9e5b88f0a93c7fbbe9bd1a77ff16895f43328", async() => {
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "410c599e7822041f042d99b3d6a12dd9e5b88f0a93c7fbbe9bd1a77ff16895f44283", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\Musay_zv97\Desktop\ASP.NET\ASP_Lesson2_MVCPractice\MVC_Practice\Views\Home\Employee2.cshtml"
         foreach (var item in Model.Emloyees)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div>\n            <h1>Firstname: ");
#nullable restore
#line 12 "C:\Users\Musay_zv97\Desktop\ASP.NET\ASP_Lesson2_MVCPractice\MVC_Practice\Views\Home\Employee2.cshtml"
                      Write(item.Firstname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>    \r\n            <h1>Lastname: ");
#nullable restore
#line 13 "C:\Users\Musay_zv97\Desktop\ASP.NET\ASP_Lesson2_MVCPractice\MVC_Practice\Views\Home\Employee2.cshtml"
                     Write(item.Lastname);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>    \r\n            <div>\r\n                <span>User ID: ");
#nullable restore
#line 15 "C:\Users\Musay_zv97\Desktop\ASP.NET\ASP_Lesson2_MVCPractice\MVC_Practice\Views\Home\Employee2.cshtml"
                          Write(item.Id);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n            </div> \r\n\r\n        </div>\n");
#nullable restore
#line 19 "C:\Users\Musay_zv97\Desktop\ASP.NET\ASP_Lesson2_MVCPractice\MVC_Practice\Views\Home\Employee2.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\Musay_zv97\Desktop\ASP.NET\ASP_Lesson2_MVCPractice\MVC_Practice\Views\Home\Employee2.cshtml"
     foreach(var item in Model.Cities)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <h2>");
#nullable restore
#line 23 "C:\Users\Musay_zv97\Desktop\ASP.NET\ASP_Lesson2_MVCPractice\MVC_Practice\Views\Home\Employee2.cshtml"
       Write(item);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n");
#nullable restore
#line 24 "C:\Users\Musay_zv97\Desktop\ASP.NET\ASP_Lesson2_MVCPractice\MVC_Practice\Views\Home\Employee2.cshtml"
    }

#line default
#line hidden
#nullable disable
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MVC_Practice.Models.EmployeeViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
