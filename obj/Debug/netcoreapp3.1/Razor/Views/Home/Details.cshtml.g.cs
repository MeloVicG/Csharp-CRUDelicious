#pragma checksum "C:\Users\M3L0V1CG41\Desktop\Coding_Dojo\C#\MVCII\Crudelicious\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "093064fd918e91b3848a2deab43aa0d7d7344809"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"093064fd918e91b3848a2deab43aa0d7d7344809", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64c0db40c4c91a29aacfb134c187d6cf7f912d39", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "093064fd918e91b3848a2deab43aa0d7d73448093284", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Dish Detail</title>\r\n");
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
#nullable restore
#line 9 "C:\Users\M3L0V1CG41\Desktop\Coding_Dojo\C#\MVCII\Crudelicious\Views\Home\Details.cshtml"
  
    Dish dishDetail = ViewBag.Details;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "093064fd918e91b3848a2deab43aa0d7d73448094675", async() => {
                WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <a href=\"/\"><h3>Home</h3></a>\r\n        <h1>DishName: ");
#nullable restore
#line 15 "C:\Users\M3L0V1CG41\Desktop\Coding_Dojo\C#\MVCII\Crudelicious\Views\Home\Details.cshtml"
                 Write(dishDetail.DishName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n        <h2>ChefName: ");
#nullable restore
#line 16 "C:\Users\M3L0V1CG41\Desktop\Coding_Dojo\C#\MVCII\Crudelicious\Views\Home\Details.cshtml"
                 Write(dishDetail.ChefName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2> \r\n        <br/>\r\n        <br/>\r\n        <h3>Comment : ");
#nullable restore
#line 19 "C:\Users\M3L0V1CG41\Desktop\Coding_Dojo\C#\MVCII\Crudelicious\Views\Home\Details.cshtml"
                 Write(dishDetail.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n        <h3>Calories : ");
#nullable restore
#line 20 "C:\Users\M3L0V1CG41\Desktop\Coding_Dojo\C#\MVCII\Crudelicious\Views\Home\Details.cshtml"
                  Write(dishDetail.Calories);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n        <h3>Tastiness : ");
#nullable restore
#line 21 "C:\Users\M3L0V1CG41\Desktop\Coding_Dojo\C#\MVCII\Crudelicious\Views\Home\Details.cshtml"
                   Write(dishDetail.Tasty);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n\r\n");
                WriteLiteral("\r\n        <a");
                BeginWriteAttribute("href", " href=\"", 788, "\"", 821, 2);
                WriteAttributeValue("", 795, "/delete/", 795, 8, true);
#nullable restore
#line 27 "C:\Users\M3L0V1CG41\Desktop\Coding_Dojo\C#\MVCII\Crudelicious\Views\Home\Details.cshtml"
WriteAttributeValue("", 803, dishDetail.DishId, 803, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Delete</a>\r\n        <a");
                BeginWriteAttribute("href", " href=\"", 845, "\"", 876, 2);
                WriteAttributeValue("", 852, "/edit/", 852, 6, true);
#nullable restore
#line 28 "C:\Users\M3L0V1CG41\Desktop\Coding_Dojo\C#\MVCII\Crudelicious\Views\Home\Details.cshtml"
WriteAttributeValue("", 858, dishDetail.DishId, 858, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Edit</a>\r\n            \r\n");
                WriteLiteral("        \r\n    </div>\r\n    \r\n    \r\n");
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