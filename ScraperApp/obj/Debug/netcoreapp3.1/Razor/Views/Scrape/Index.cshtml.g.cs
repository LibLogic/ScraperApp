#pragma checksum "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a7cfaf59616b8e4a9dfdc14e35136087297bd08"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a7cfaf59616b8e4a9dfdc14e35136087297bd08", @"/Views/Scrape/Index.cshtml")]
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
            WriteLiteral("\r\n<h2>Scrape Time —  ");
#nullable restore
#line 6 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
              Write(Model.Rows[Model.Rows.Count - 10][1]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
<button>Latest Scrape</button>
<button>New Scrape</button>
<div style=""border-top: 1px solid black; border-bottom: 1px solid black; border-left: 1px solid black; margin: 2% 0 2% 0; padding: 1% 1% 0 1%; width: auto; height: 345px; overflow-x: auto; overflow-y: scroll;"">
    <table style=""table-layout: auto; width: 100%; border: 3px solid green"" class=""table table-bordered table-striped"">
        <tr>
            <!--            <th>Scrape Time</th> -->
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
        </tr>

");
#nullable restore
#line 28 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
         for (int i = Model.Rows.Count - 10; i <  Model.Rows.Count; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
               Write(Model.Rows[i][2]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
               Write(Model.Rows[i][3]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
               Write(Model.Rows[i][4]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
               Write(Model.Rows[i][5]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
               Write(Model.Rows[i][6]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
               Write(Model.Rows[i][7]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
               Write(Model.Rows[i][8]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
               Write(Model.Rows[i][9]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
               Write(Model.Rows[i][10]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
               Write(Model.Rows[i][11]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
               Write(Model.Rows[i][12]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 42 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
               Write(Model.Rows[i][13]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 43 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
               Write(Model.Rows[i][14]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 45 "C:\Users\Tom\Desktop\Development\CapstoneProject\ScraperApp\Views\Scrape\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>\r\n<button>Start Date</button>\r\n<button>Previous</button>\r\n<button>Next</button>");
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
