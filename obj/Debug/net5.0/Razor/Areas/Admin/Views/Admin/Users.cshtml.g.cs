#pragma checksum "C:\Users\enes\Desktop\FlavorHouse-master\Areas\Admin\Views\Admin\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d34bd8192351bf1123f33d0f866de0a5e6db9911"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Admin_Users), @"mvc.1.0.view", @"/Areas/Admin/Views/Admin/Users.cshtml")]
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
#line 1 "C:\Users\enes\Desktop\FlavorHouse-master\Areas\Admin\Views\Admin\Users.cshtml"
using FlavorHouse.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d34bd8192351bf1123f33d0f866de0a5e6db9911", @"/Areas/Admin/Views/Admin/Users.cshtml")]
    public class Areas_Admin_Views_Admin_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ApplicationUser>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 4 "C:\Users\enes\Desktop\FlavorHouse-master\Areas\Admin\Views\Admin\Users.cshtml"
  
    ViewData["Title"] = "Users";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n\n\n\n<table class=\"table table-bordered\" style=\"margin-left:200px\">\n\n    <tr>\n        <th>User Name</th>\n        <th>Name</th>\n        <th>Surname</th>\n    </tr>\n");
#nullable restore
#line 20 "C:\Users\enes\Desktop\FlavorHouse-master\Areas\Admin\Views\Admin\Users.cshtml"
     foreach (var i in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>");
#nullable restore
#line 23 "C:\Users\enes\Desktop\FlavorHouse-master\Areas\Admin\Views\Admin\Users.cshtml"
           Write(i.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</td>\n            <td>");
#nullable restore
#line 24 "C:\Users\enes\Desktop\FlavorHouse-master\Areas\Admin\Views\Admin\Users.cshtml"
           Write(i.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n            <td>");
#nullable restore
#line 25 "C:\Users\enes\Desktop\FlavorHouse-master\Areas\Admin\Views\Admin\Users.cshtml"
           Write(i.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n        </tr>\n");
#nullable restore
#line 27 "C:\Users\enes\Desktop\FlavorHouse-master\Areas\Admin\Views\Admin\Users.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
