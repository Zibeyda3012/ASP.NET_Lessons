#pragma checksum "C:\Users\Zibeyde\Desktop\ASP.NET_Lessons\ASP_Lesson2_MVCPractice\MVC_Practice\Views\Shared\_Layout.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "74ab613252df6d89451fe24679772f8c542003931b50faa9dd8eefa83db73eaf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"74ab613252df6d89451fe24679772f8c542003931b50faa9dd8eefa83db73eaf", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"6527b91c79defe613cf45f20aa8ec1bf663d068c0357de1cf60eb12f8d476001", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline my-2 my-lg-0"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74ab613252df6d89451fe24679772f8c542003931b50faa9dd8eefa83db73eaf4666", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
                Write(
#nullable restore
#line 6 "C:\Users\Zibeyde\Desktop\ASP.NET_Lessons\ASP_Lesson2_MVCPractice\MVC_Practice\Views\Shared\_Layout.cshtml"
            ViewBag.Title

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "74ab613252df6d89451fe24679772f8c542003931b50faa9dd8eefa83db73eaf5332", async() => {
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
                WriteLiteral("\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74ab613252df6d89451fe24679772f8c542003931b50faa9dd8eefa83db73eaf7238", async() => {
                WriteLiteral(@"
    <nav class=""navbar navbar-expand-lg navbar-light bg-light"">
        <a class=""navbar-brand"" href=""#"">Navbar</a>
        <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
            <span class=""navbar-toggler-icon""></span>
        </button>

        <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
            <ul class=""navbar-nav mr-auto"">
                <li class=""nav-item active"">
                    <a class=""nav-link"" href=""#"">Home <span class=""sr-only"">(current)</span></a>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link"" href=""#"">Link</a>
                </li>
                <li class=""nav-item dropdown"">
                    <a class=""nav-link dropdown-toggle"" href=""#"" id=""navbarDropdown"" role=""button"" data-toggle=""dropdown"" aria-haspopup=""true"" aria-expanded=""false");
                WriteLiteral(@""">
                        Dropdown
                    </a>
                    <div class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
                        <a class=""dropdown-item"" href=""#"">Action</a>
                        <a class=""dropdown-item"" href=""#"">Another action</a>
                        <div class=""dropdown-divider""></div>
                        <a class=""dropdown-item"" href=""#"">Something else here</a>
                    </div>
                </li>
                <li class=""nav-item"">
                    <a class=""nav-link disabled"" href=""#"">Disabled</a>
                </li>
            </ul>
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74ab613252df6d89451fe24679772f8c542003931b50faa9dd8eefa83db73eaf9314", async() => {
                    WriteLiteral("\r\n                <input class=\"form-control mr-sm-2\" type=\"search\" placeholder=\"Search\" aria-label=\"Search\">\r\n                <button class=\"btn btn-outline-success my-2 my-sm-0\" type=\"submit\">Search</button>\r\n            ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n    </nav>\r\n    <div>\r\n        ");
                Write(
#nullable restore
#line 46 "C:\Users\Zibeyde\Desktop\ASP.NET_Lessons\ASP_Lesson2_MVCPractice\MVC_Practice\Views\Shared\_Layout.cshtml"
         RenderBody()

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("\r\n    </div>\r\n    <div class=\"container my-5\">\r\n        <footer class=\"text-center text-lg-start text-white\"\r\n                style=\"background-color: #3e4551\">\r\n            <div class=\"container p-4 pb-0\">\r\n                <section");
                BeginWriteAttribute("class", " class=\"", 2466, "\"", 2474, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <div class=""row"">
                        <div class=""col-lg-4 col-md-6 mb-4 mb-md-0"">
                            <h5 class=""text-uppercase"">FOOTER CONTENT</h5>

                            <p>
                                Lorem ipsum dolor sit amet consectetur adipisicing elit.
                                Molestiae modi cum ipsam ad, illo possimus laborum ut
                                reiciendis obcaecati. Ducimus, quas. Corrupti, pariatur eaque?
                                Reiciendis assumenda iusto sapiente inventore animi?
                            </p>
                        </div>
                        <div class=""col-lg-2 col-md-6 mb-4 mb-md-0"">
                            <h5 class=""text-uppercase"">Links</h5>

                            <ul class=""list-unstyled mb-0"">
                                <li>
                                    <a href=""#!"" class=""text-white"">Link 1</a>
                                </li>
                   ");
                WriteLiteral(@"             <li>
                                    <a href=""#!"" class=""text-white"">Link 2</a>
                                </li>
                                <li>
                                    <a href=""#!"" class=""text-white"">Link 3</a>
                                </li>
                                <li>
                                    <a href=""#!"" class=""text-white"">Link 4</a>
                                </li>
                            </ul>
                        </div>
                        <div class=""col-lg-2 col-md-6 mb-4 mb-md-0"">
                            <h5 class=""text-uppercase"">Links</h5>

                            <ul class=""list-unstyled mb-0"">
                                <li>
                                    <a href=""#!"" class=""text-white"">Link 1</a>
                                </li>
                                <li>
                                    <a href=""#!"" class=""text-white"">Link 2</a>
                              ");
                WriteLiteral(@"  </li>
                                <li>
                                    <a href=""#!"" class=""text-white"">Link 3</a>
                                </li>
                                <li>
                                    <a href=""#!"" class=""text-white"">Link 4</a>
                                </li>
                            </ul>
                        </div>
                        <div class=""col-lg-2 col-md-6 mb-4 mb-md-0"">
                            <h5 class=""text-uppercase"">Links</h5>

                            <ul class=""list-unstyled mb-0"">
                                <li>
                                    <a href=""#!"" class=""text-white"">Link 1</a>
                                </li>
                                <li>
                                    <a href=""#!"" class=""text-white"">Link 2</a>
                                </li>
                                <li>
                                    <a href=""#!"" class=""text-white"">Link 3</a>
  ");
                WriteLiteral(@"                              </li>
                                <li>
                                    <a href=""#!"" class=""text-white"">Link 4</a>
                                </li>
                            </ul>
                        </div>
                        <div class=""col-lg-2 col-md-6 mb-4 mb-md-0"">
                            <h5 class=""text-uppercase"">Links</h5>

                            <ul class=""list-unstyled mb-0"">
                                <li>
                                    <a href=""#!"" class=""text-white"">Link 1</a>
                                </li>
                                <li>
                                    <a href=""#!"" class=""text-white"">Link 2</a>
                                </li>
                                <li>
                                    <a href=""#!"" class=""text-white"">Link 3</a>
                                </li>
                                <li>
                                    <a href=""#!"" class");
                WriteLiteral("=\"text-white\">Link 4</a>\r\n                                </li>\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </section>\r\n\r\n                <hr class=\"mb-4\" />\r\n\r\n                <section");
                BeginWriteAttribute("class", " class=\"", 6824, "\"", 6832, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    <p class=""d-flex justify-content-center align-items-center"">
                        <span class=""me-3"">Register for free</span>
                        <button type=""button"" class=""btn btn-outline-light btn-rounded"">
                            Sign up!
                        </button>
                    </p>
                </section>

                <hr class=""mb-4"" />

                <section class=""mb-4 text-center"">
                    <a class=""btn btn-outline-light btn-floating m-1""
                       href=""#!""
                       role=""button"">
                        <i class=""fab fa-facebook-f""></i>
                    </a>

                    <a class=""btn btn-outline-light btn-floating m-1""
                       href=""#!""
                       role=""button"">
                        <i class=""fab fa-twitter""></i>
                    </a>

                    <a class=""btn btn-outline-light btn-floating m-1""
                       href=""#");
                WriteLiteral(@"!""
                       role=""button"">
                        <i class=""fab fa-google""></i>
                    </a>

                    <a class=""btn btn-outline-light btn-floating m-1""
                       href=""#!""
                       role=""button"">
                        <i class=""fab fa-instagram""></i>
                    </a>

                    <a class=""btn btn-outline-light btn-floating m-1""
                       href=""#!""
                       role=""button"">
                        <i class=""fab fa-linkedin-in""></i>
                    </a>

                    <a class=""btn btn-outline-light btn-floating m-1""
                       href=""#!""
                       role=""button"">
                        <i class=""fab fa-github""></i>
                    </a>
                </section>
            </div>
            <div class=""text-center p-3""
                 style=""background-color: rgba(0, 0, 0, 0.2)"">
                © 2020 Copyright:
                <a cla");
                WriteLiteral("ss=\"text-white\" href=\"https://mdbootstrap.com/\">MDBootstrap.com</a>\r\n            </div>\r\n        </footer>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
