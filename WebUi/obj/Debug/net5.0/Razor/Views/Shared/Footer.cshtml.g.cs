#pragma checksum "C:\MyProjects\VisualStudio\Bismillah\WebUi\Views\Shared\Footer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81abbf82de0e2940e99227f1b7ae0a7e91bd7547"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Footer), @"mvc.1.0.view", @"/Views/Shared/Footer.cshtml")]
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
#line 1 "C:\MyProjects\VisualStudio\Bismillah\WebUi\Views\_ViewImports.cshtml"
using WebUi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MyProjects\VisualStudio\Bismillah\WebUi\Views\_ViewImports.cshtml"
using WebUi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\MyProjects\VisualStudio\Bismillah\WebUi\Views\_ViewImports.cshtml"
using Entities.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81abbf82de0e2940e99227f1b7ae0a7e91bd7547", @"/Views/Shared/Footer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1951570255c5d2000fe6ba94a0f2b801fe8c0c8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Footer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<footer>
    
        <!-- footer -->
        <div class=""footer-cpy text-center"">
            <div class=""footer-social"">
                <div class=""copyrighttop"">
                    <ul>
                        <li class=""mx-3"">
                            <a class=""facebook"" href=""#"">
                                <i class=""fab fa-facebook-f""></i>
                                <span>Facebook</span>
                            </a>
                        </li>

                        <li>
                            <a class=""facebook"" href=""#"">
                                <i class=""fab fa-twitter""></i>
                                <span>Twitter</span>
                            </a>
                        </li>
                        <li>
                            <a class=""facebook"" href=""#"">
");
            WriteLiteral(@"                                <i class=""fab fa-instagram""></i>
                                <span>Instagram</span>
                            </a>
                        </li>
                        <li>
                            <a class=""facebook"" href=""#"">
                                <i class=""fab fa-linkedin""></i>
                                <span>Linkedin</span>
                            </a>
                        </li>

                        <li class=""mx-3"">
                            <a class=""facebook"" href=""#"">
                                <i class=""fab fa-google-plus-g""></i>
                                <span>Google+</span>
                            </a>
                        </li>


                    </ul>

                </div>
            </div>
            <div class=""w3layouts-agile-copyrightbottom"">
                <p>
                    © ");
#nullable restore
#line 49 "C:\MyProjects\VisualStudio\Bismillah\WebUi\Views\Shared\Footer.cshtml"
                 Write(DateTime.Now.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Weblog | Design by\r\n                    <a href=\"http://w3layouts.com/\">W3layouts</a>\r\n                </p>\r\n\r\n            </div>\r\n        </div>\r\n\r\n        <!-- //footer -->\r\n\r\n\r\n    </div>\r\n</footer>");
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
