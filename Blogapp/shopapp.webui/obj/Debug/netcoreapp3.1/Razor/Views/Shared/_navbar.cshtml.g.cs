#pragma checksum "C:\Users\cenke\Desktop\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "986391f51a94db19a32f6ca356a4a84ed226d082"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__navbar), @"mvc.1.0.view", @"/Views/Shared/_navbar.cshtml")]
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
#line 2 "C:\Users\cenke\Desktop\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\cenke\Desktop\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\cenke\Desktop\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\cenke\Desktop\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\cenke\Desktop\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\cenke\Desktop\shopapp\shopapp.webui\Views\_ViewImports.cshtml"
using shopapp.webui.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"986391f51a94db19a32f6ca356a4a84ed226d082", @"/Views/Shared/_navbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e008609cd3085ab4ba2d4ce0bd2e79f33e96950", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__navbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "categories", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""navbar bg-secondary navbar-dark navbar-expand-sm"">
        <div class=""container"">
            <a href=""/"" class=""navbar-brand"">BlogApp</a>
            <ul class=""navbar-nav mr-auto"">
                <li class=""nav-item"">
                    <a href=""/Blogs"" class=""nav-link"">Bloglar</a>
                </li>
                <li class=""nav-item"">
                    <a href=""http://localhost:5000/home/about"" class=""nav-link"">Hakkımızda</a>
                </li>
                <li class=""nav-item"">
                    <a href=""http://localhost:5000/home/contact"" class=""nav-link"">İletişim</a>
                </li>
");
#nullable restore
#line 14 "C:\Users\cenke\Desktop\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
                 if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"nav-item\">\r\n                        <a href=\"/cart\" class=\"nav-link\">Sonra Oku</a>\r\n                    </li>\r\n");
#nullable restore
#line 19 "C:\Users\cenke\Desktop\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
                    if (User.IsInRole("admin"))
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"nav-item\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "986391f51a94db19a32f6ca356a4a84ed226d0826165", async() => {
                WriteLiteral("Kategoriler");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </li>
                        <li class=""nav-item"">
                            <a href=""/admin/blogs"" class=""nav-link"">Bloglar</a>
                        </li>
                        <li class=""nav-item"">
                             <a href=""/admin/role/list"" class=""nav-link"">Roller</a>
                        </li>
                        <li class=""nav-item"">
                             <a href=""/admin/user/list"" class=""nav-link"">Kullanıcılar</a>
                        </li>
");
#nullable restore
#line 33 "C:\Users\cenke\Desktop\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
                    }
                    
                }    

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n\r\n            <ul class=\"navbar-nav ml-auto\">\r\n");
#nullable restore
#line 39 "C:\Users\cenke\Desktop\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
                  if (User.Identity.IsAuthenticated)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"nav-item\">\r\n                        <a href=\"/account/manage\" class=\"nav-link\">\r\n                            ");
#nullable restore
#line 43 "C:\Users\cenke\Desktop\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
                       Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </a>\r\n                    </li>\r\n                    <li class=\"nav-item\">\r\n                        <a href=\"/account/logout\" class=\"nav-link\">Çıkış Yap</a>\r\n                    </li>\r\n");
#nullable restore
#line 49 "C:\Users\cenke\Desktop\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
                }
                 else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <li class=""nav-item"">
                        <a href=""/account/register"" class=""nav-link"">Kayıt Ol</a>
                    </li>
                    <li class=""nav-item"">
                        <a href=""/account/login"" class=""nav-link"">Giriş Yap</a>
                    </li> 
");
#nullable restore
#line 58 "C:\Users\cenke\Desktop\shopapp\shopapp.webui\Views\Shared\_navbar.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n</div>\r\n\r\n\r\n                    \r\n                \r\n\r\n\r\n\r\n\r\n             \r\n\r\n\r\n           \r\n       \r\n                \r\n                    \r\n                \r\n            ");
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