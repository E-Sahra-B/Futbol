#pragma checksum "C:\MyProjects\VisualStudio\Bismillah\WebUi\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5467ef920c34e42fa5530aa82fa68290baa5faf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5467ef920c34e42fa5530aa82fa68290baa5faf", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cc37074dda95a63c32d47e5fe595668312d347e", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.DTOs.UserForLoginDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\MyProjects\VisualStudio\Bismillah\WebUi\Views\Login\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<section class=\"main-content-w3layouts-agileits\">\r\n    <div class=\"container\">\r\n        <h3 class=\"tittle\" style=\"color:#01cd73\">Giriş Sayfası</h3>\r\n        <div class=\"inner-sec\">\r\n            <div class=\"login p-5 bg-light mx-auto mw-100\">\r\n\r\n");
#nullable restore
#line 13 "C:\MyProjects\VisualStudio\Bismillah\WebUi\Views\Login\Index.cshtml"
                 using (Html.BeginForm("Index", "Login", FormMethod.Post))
                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"form-row\">\r\n                        <div class=\"form-group col-md-6\">\r\n                            <label for=\"exampleInputPassword1 mb-2\">Mail</label>\r\n                            ");
#nullable restore
#line 19 "C:\MyProjects\VisualStudio\Bismillah\WebUi\Views\Login\Index.cshtml"
                       Write(Html.TextBoxFor(x => x.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"form-group col-md-6\">\r\n                            <label for=\"exampleInputPassword2 mb-2\">Şifre</label>\r\n                            ");
#nullable restore
#line 23 "C:\MyProjects\VisualStudio\Bismillah\WebUi\Views\Login\Index.cshtml"
                       Write(Html.PasswordFor(x => x.Password, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <button type=\"submit\" class=\"btn btn-primary submit mb-4\">Giriş Yap</button>\r\n");
#nullable restore
#line 27 "C:\MyProjects\VisualStudio\Bismillah\WebUi\Views\Login\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <a href=\"/Team/Index/\" class=\"btn btn-outline-success\">team</a>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.DTOs.UserForLoginDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
