#pragma checksum "C:\Users\M3L0V1CG41\Desktop\Coding_Dojo\C#\MVCII\Crudelicious\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0a81aade2e3ad3a7323c23a71265e9a38c150d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\M3L0V1CG41\Desktop\Coding_Dojo\C#\MVCII\Crudelicious\Views\_ViewImports.cshtml"
using Crudelicious;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\M3L0V1CG41\Desktop\Coding_Dojo\C#\MVCII\Crudelicious\Views\_ViewImports.cshtml"
using Crudelicious.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0a81aade2e3ad3a7323c23a71265e9a38c150d2", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64c0db40c4c91a29aacfb134c187d6cf7f912d39", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\M3L0V1CG41\Desktop\Coding_Dojo\C#\MVCII\Crudelicious\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1>Welcome to CRUDelicious</h1>\r\n    <a href=\"/news\">ADD A DISH</a>\r\n\r\n    <br/>\r\n    <br/>\r\n    <h4>Check out some recent dishes!</h4>\r\n\r\n    <ul>\r\n");
#nullable restore
#line 14 "C:\Users\M3L0V1CG41\Desktop\Coding_Dojo\C#\MVCII\Crudelicious\Views\Home\Index.cshtml"
         foreach (var dish in ViewBag.Dishes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 300, "\"", 326, 2);
            WriteAttributeValue("", 307, "detail/", 307, 7, true);
#nullable restore
#line 16 "C:\Users\M3L0V1CG41\Desktop\Coding_Dojo\C#\MVCII\Crudelicious\Views\Home\Index.cshtml"
WriteAttributeValue("", 314, dish.DishId, 314, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        <li>");
#nullable restore
#line 17 "C:\Users\M3L0V1CG41\Desktop\Coding_Dojo\C#\MVCII\Crudelicious\Views\Home\Index.cshtml"
       Write(dish.ChefName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 17 "C:\Users\M3L0V1CG41\Desktop\Coding_Dojo\C#\MVCII\Crudelicious\Views\Home\Index.cshtml"
                      Write(dish.DishName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            </a>\r\n");
#nullable restore
#line 19 "C:\Users\M3L0V1CG41\Desktop\Coding_Dojo\C#\MVCII\Crudelicious\Views\Home\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n\r\n</div>\r\n");
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