#pragma checksum "C:\Users\M3L0V1CG41\Desktop\Coding_Dojo\C#\MVCII\Crudelicious\Views\Home\Dishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9adf940e3fb761a1444bf6500045f51b76e78c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dishes), @"mvc.1.0.view", @"/Views/Home/Dishes.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9adf940e3fb761a1444bf6500045f51b76e78c3", @"/Views/Home/Dishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64c0db40c4c91a29aacfb134c187d6cf7f912d39", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\M3L0V1CG41\Desktop\Coding_Dojo\C#\MVCII\Crudelicious\Views\Home\Dishes.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <div>
        <h1>Chefs N Dishes</h1>
        <h3>Yum take a look at our dishes!</h3>
        <a class=""btn btn-primary""href=""/new-dish"">ADD A DISH</a>
    </div>
    <a href=""/"">Chefs</a> |
    <a href=""/dishes"">Dishes</a>

    <br/>
    <br/>
    <h4>Check out Our Dishes</h4>

    <ul>
");
#nullable restore
#line 19 "C:\Users\M3L0V1CG41\Desktop\Coding_Dojo\C#\MVCII\Crudelicious\Views\Home\Dishes.cshtml"
         foreach (var dish in ViewBag.Dishes)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <Table class=""table table-dark table-sm"">
            <tr>
                <th>Dish Name</th>
                <th>Chef</th>
                <th>Tastiness</th>
                <th>Calories</th>
            </tr>
            <tr>
                <td>");
#nullable restore
#line 29 "C:\Users\M3L0V1CG41\Desktop\Coding_Dojo\C#\MVCII\Crudelicious\Views\Home\Dishes.cshtml"
               Write(dish.DishName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\M3L0V1CG41\Desktop\Coding_Dojo\C#\MVCII\Crudelicious\Views\Home\Dishes.cshtml"
               Write(dish.DishChef.ChefName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\M3L0V1CG41\Desktop\Coding_Dojo\C#\MVCII\Crudelicious\Views\Home\Dishes.cshtml"
               Write(dish.Tasty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\M3L0V1CG41\Desktop\Coding_Dojo\C#\MVCII\Crudelicious\Views\Home\Dishes.cshtml"
               Write(dish.Calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("            </tr>\r\n        </Table>\r\n");
#nullable restore
#line 36 "C:\Users\M3L0V1CG41\Desktop\Coding_Dojo\C#\MVCII\Crudelicious\Views\Home\Dishes.cshtml"
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