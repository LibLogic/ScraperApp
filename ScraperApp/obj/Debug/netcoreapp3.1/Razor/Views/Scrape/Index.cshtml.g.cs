#pragma checksum "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59449a18902099c704f827311d21f68e49d803ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Scrape_Index), @"mvc.1.0.view", @"/Views/Scrape/Index.cshtml")]
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
#line 1 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\_ViewImports.cshtml"
using ScraperApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\_ViewImports.cshtml"
using ScraperApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59449a18902099c704f827311d21f68e49d803ec", @"/Views/Scrape/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"580747e4918548fa265578502798f76c752c3516", @"/Views/_ViewImports.cshtml")]
    public class Views_Scrape_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Data.DataTable>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-bordered table-striped"">
    <tr>
        <th>Scrape Time</th>
        <th>Symbol</th>
        <th>Last Price</th>
        <th>Change</th>
        <th> Chg. %</th>
        <th>Currency</th>
        <th>Market Time</th>
        <th>Volume</th>
        <th>Shares</th>
        <th>Avg. Volume</th>
        <th>Day Range</th>
        <th>Day Chart</th>
        <th>52 Week Range</th>
        <th>Market Cap</th>
    <tr>
");
#nullable restore
#line 23 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
         for (int i = 0; i < 10; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 26 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
       Write(Model.Rows[i][1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 27 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
       Write(Model.Rows[i][2]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 28 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
       Write(Model.Rows[i][3]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 29 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
       Write(Model.Rows[i][4]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 30 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
       Write(Model.Rows[i][5]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 31 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
       Write(Model.Rows[i][6]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 32 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
       Write(Model.Rows[i][7]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 33 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
       Write(Model.Rows[i][8]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 34 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
       Write(Model.Rows[i][9]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 35 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
       Write(Model.Rows[i][10]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 36 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
       Write(Model.Rows[i][11]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 37 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
       Write(Model.Rows[i][12]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 38 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
       Write(Model.Rows[i][13]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 39 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
       Write(Model.Rows[i][14]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n");
#nullable restore
#line 41 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Data.DataTable> Html { get; private set; }
    }
}
#pragma warning restore 1591
