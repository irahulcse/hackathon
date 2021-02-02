#pragma checksum "/home/rahul/Desktop/dotnet-docker/samples/aspnetapp/aspnetapp/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e70c100fbd1f124731b548abaacdd60d7afd5646"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(aspnetapp.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace aspnetapp.Pages
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
#line 1 "/home/rahul/Desktop/dotnet-docker/samples/aspnetapp/aspnetapp/Pages/_ViewImports.cshtml"
using aspnetapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/rahul/Desktop/dotnet-docker/samples/aspnetapp/aspnetapp/Pages/Index.cshtml"
using System.Runtime.InteropServices;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/rahul/Desktop/dotnet-docker/samples/aspnetapp/aspnetapp/Pages/Index.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/rahul/Desktop/dotnet-docker/samples/aspnetapp/aspnetapp/Pages/Index.cshtml"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e70c100fbd1f124731b548abaacdd60d7afd5646", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d1712f3ea81a8e2b40eee4bbea838536602add0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 6 "/home/rahul/Desktop/dotnet-docker/samples/aspnetapp/aspnetapp/Pages/Index.cshtml"
  
    ViewData["Title"] = "Home page";
    var process = Process.GetCurrentProcess();

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome to .NET</h1>\r\n\r\n    <h5>Environment</h5>\r\n    <p>");
#nullable restore
#line 15 "/home/rahul/Desktop/dotnet-docker/samples/aspnetapp/aspnetapp/Pages/Index.cshtml"
  Write(RuntimeInformation.FrameworkDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral(" (");
#nullable restore
#line 15 "/home/rahul/Desktop/dotnet-docker/samples/aspnetapp/aspnetapp/Pages/Index.cshtml"
                                            Write(RuntimeInformation.ProcessArchitecture);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</p>\r\n    <p>");
#nullable restore
#line 16 "/home/rahul/Desktop/dotnet-docker/samples/aspnetapp/aspnetapp/Pages/Index.cshtml"
  Write(RuntimeInformation.OSDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n</div>\r\n\r\n<div>\r\n    <h5 class=\"text-center\">Metrics</h5>\r\n    <table width=\"500\" align=\"center\" class=\"table-striped table-hover\">\r\n        <tr>\r\n            <td>Containerized</td>\r\n            <td>");
#nullable restore
#line 24 "/home/rahul/Desktop/dotnet-docker/samples/aspnetapp/aspnetapp/Pages/Index.cshtml"
            Write(Environment.GetEnvironmentVariable("DOTNET_RUNNING_IN_CONTAINER") is object ? "true" : "false");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>CPU cores</td>\r\n            <td>");
#nullable restore
#line 28 "/home/rahul/Desktop/dotnet-docker/samples/aspnetapp/aspnetapp/Pages/Index.cshtml"
           Write(Environment.ProcessorCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 30 "/home/rahul/Desktop/dotnet-docker/samples/aspnetapp/aspnetapp/Pages/Index.cshtml"
     if (RuntimeInformation.OSDescription.StartsWith("Linux") && Directory.Exists("/sys/fs/cgroup/memory"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>cgroup memory usage</td>\r\n            <td>");
#nullable restore
#line 34 "/home/rahul/Desktop/dotnet-docker/samples/aspnetapp/aspnetapp/Pages/Index.cshtml"
           Write(System.IO.File.ReadAllLines("/sys/fs/cgroup/memory/memory.usage_in_bytes")[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 36 "/home/rahul/Desktop/dotnet-docker/samples/aspnetapp/aspnetapp/Pages/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>Memory, current usage (bytes)</td>\r\n            <td>");
#nullable restore
#line 39 "/home/rahul/Desktop/dotnet-docker/samples/aspnetapp/aspnetapp/Pages/Index.cshtml"
           Write(process.WorkingSet64);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td>Memory, max available (bytes)</td>\r\n            <td>");
#nullable restore
#line 43 "/home/rahul/Desktop/dotnet-docker/samples/aspnetapp/aspnetapp/Pages/Index.cshtml"
           Write(process.MaxWorkingSet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>    \r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591