#pragma checksum "E:\其它\jianyiaspnetcore\jianyiaspnetcore\Views\Todo\ManageUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b02910097a7b48ce2cb31438295b67bcf7590fec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Todo_ManageUsers), @"mvc.1.0.view", @"/Views/Todo/ManageUsers.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Todo/ManageUsers.cshtml", typeof(AspNetCore.Views_Todo_ManageUsers))]
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
#line 1 "E:\其它\jianyiaspnetcore\jianyiaspnetcore\Views\_ViewImports.cshtml"
using jianyiaspnetcore;

#line default
#line hidden
#line 2 "E:\其它\jianyiaspnetcore\jianyiaspnetcore\Views\_ViewImports.cshtml"
using jianyiaspnetcore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b02910097a7b48ce2cb31438295b67bcf7590fec", @"/Views/Todo/ManageUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f44b4b32513dc77d424e594aaabf52de924a9794", @"/Views/_ViewImports.cshtml")]
    public class Views_Todo_ManageUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ManageUsersViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\其它\jianyiaspnetcore\jianyiaspnetcore\Views\Todo\ManageUsers.cshtml"
  
    ViewData["Title"] = "Manage users";

#line default
#line hidden
            BeginContext(79, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(86, 17, false);
#line 7 "E:\其它\jianyiaspnetcore\jianyiaspnetcore\Views\Todo\ManageUsers.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(103, 170, true);
            WriteLiteral("</h2>\r\n\r\n<h3>Administrators</h3>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <td>Id</td>\r\n            <td>Email</td>\r\n        </tr>\r\n    </thead>\r\n\r\n");
            EndContext();
#line 19 "E:\其它\jianyiaspnetcore\jianyiaspnetcore\Views\Todo\ManageUsers.cshtml"
     foreach (var user in Model.Administrators)
    {

#line default
#line hidden
            BeginContext(329, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(360, 7, false);
#line 22 "E:\其它\jianyiaspnetcore\jianyiaspnetcore\Views\Todo\ManageUsers.cshtml"
           Write(user.Id);

#line default
#line hidden
            EndContext();
            BeginContext(367, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(391, 10, false);
#line 23 "E:\其它\jianyiaspnetcore\jianyiaspnetcore\Views\Todo\ManageUsers.cshtml"
           Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(401, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 25 "E:\其它\jianyiaspnetcore\jianyiaspnetcore\Views\Todo\ManageUsers.cshtml"
    }

#line default
#line hidden
            BeginContext(430, 167, true);
            WriteLiteral("</table>\r\n\r\n<h3>Everyone</h3>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <td>Id</td>\r\n            <td>Email</td>\r\n        </tr>\r\n    </thead>\r\n\r\n");
            EndContext();
#line 38 "E:\其它\jianyiaspnetcore\jianyiaspnetcore\Views\Todo\ManageUsers.cshtml"
     foreach (var user in Model.Everyone)
    {

#line default
#line hidden
            BeginContext(647, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(678, 7, false);
#line 41 "E:\其它\jianyiaspnetcore\jianyiaspnetcore\Views\Todo\ManageUsers.cshtml"
           Write(user.Id);

#line default
#line hidden
            EndContext();
            BeginContext(685, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(709, 10, false);
#line 42 "E:\其它\jianyiaspnetcore\jianyiaspnetcore\Views\Todo\ManageUsers.cshtml"
           Write(user.Email);

#line default
#line hidden
            EndContext();
            BeginContext(719, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 44 "E:\其它\jianyiaspnetcore\jianyiaspnetcore\Views\Todo\ManageUsers.cshtml"
    }

#line default
#line hidden
            BeginContext(748, 10, true);
            WriteLiteral("</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ManageUsersViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
