#pragma checksum "C:\CIDM3312\MyWebCalculator\Views\Converter\Divide.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf1a280965bbdf84c1f9608ec8d829c4d555be2a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Converter_Divide), @"mvc.1.0.view", @"/Views/Converter/Divide.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Converter/Divide.cshtml", typeof(AspNetCore.Views_Converter_Divide))]
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
#line 1 "C:\CIDM3312\MyWebCalculator\Views\_ViewImports.cshtml"
using MyWebCalculator;

#line default
#line hidden
#line 2 "C:\CIDM3312\MyWebCalculator\Views\_ViewImports.cshtml"
using MyWebCalculator.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf1a280965bbdf84c1f9608ec8d829c4d555be2a", @"/Views/Converter/Divide.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"723c93cf8501ee692a6dcd53c1cb5152db45382f", @"/Views/_ViewImports.cshtml")]
    public class Views_Converter_Divide : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\CIDM3312\MyWebCalculator\Views\Converter\Divide.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 29, true);
            WriteLiteral("\r\n<h1>Divide Result</h1>\r\n<p>");
            EndContext();
            BeginContext(57, 24, false);
#line 6 "C:\CIDM3312\MyWebCalculator\Views\Converter\Divide.cshtml"
Write(ViewData["DivideResult"]);

#line default
#line hidden
            EndContext();
            BeginContext(81, 8, true);
            WriteLiteral("</p>\r\n\r\n");
            EndContext();
#line 8 "C:\CIDM3312\MyWebCalculator\Views\Converter\Divide.cshtml"
  
    int left = Convert.ToInt32(ViewData["Left"]);
    int right = Convert.ToInt32(ViewData["Right"]);
    int result = left / right;

#line default
#line hidden
            BeginContext(232, 5, true);
            WriteLiteral("\r\n<p>");
            EndContext();
            BeginContext(238, 6, false);
#line 14 "C:\CIDM3312\MyWebCalculator\Views\Converter\Divide.cshtml"
Write(result);

#line default
#line hidden
            EndContext();
            BeginContext(244, 4, true);
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
