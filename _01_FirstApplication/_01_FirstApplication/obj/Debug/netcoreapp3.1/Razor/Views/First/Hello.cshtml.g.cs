#pragma checksum "C:\Users\Admin\source\repos\_01_FirstApplication\_01_FirstApplication\Views\First\Hello.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e751f4923fc3feb4f30755bea8f4817312ddbd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_First_Hello), @"mvc.1.0.view", @"/Views/First/Hello.cshtml")]
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
#line 1 "C:\Users\Admin\source\repos\_01_FirstApplication\_01_FirstApplication\Views\_ViewImports.cshtml"
using _01_FirstApplication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Admin\source\repos\_01_FirstApplication\_01_FirstApplication\Views\_ViewImports.cshtml"
using _01_FirstApplication.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e751f4923fc3feb4f30755bea8f4817312ddbd3", @"/Views/First/Hello.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d7c7f2f4e8298378c7ce8c4c5926e6ef7009d74", @"/Views/_ViewImports.cshtml")]
    public class Views_First_Hello : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Admin\source\repos\_01_FirstApplication\_01_FirstApplication\Views\First\Hello.cshtml"
  
    ViewData["Title"] = "Hello";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Hello</h2>\r\n<h2>");
#nullable restore
#line 6 "C:\Users\Admin\source\repos\_01_FirstApplication\_01_FirstApplication\Views\First\Hello.cshtml"
Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>");
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
