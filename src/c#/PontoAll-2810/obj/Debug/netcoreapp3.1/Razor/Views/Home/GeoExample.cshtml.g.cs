#pragma checksum "C:\Users\Suporte\source\repos\PontoAll-2810\Views\Home\GeoExample.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa96a095828deae8c76d0720ef2cfb892cf5c347"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GeoExample), @"mvc.1.0.view", @"/Views/Home/GeoExample.cshtml")]
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
#line 1 "C:\Users\Suporte\source\repos\PontoAll-2810\Views\_ViewImports.cshtml"
using PontoAll_2810;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Suporte\source\repos\PontoAll-2810\Views\_ViewImports.cshtml"
using PontoAll_2810.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa96a095828deae8c76d0720ef2cfb892cf5c347", @"/Views/Home/GeoExample.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d637451a86298b692301512b56189998c7f7ba5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GeoExample : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PontoAll_2810.Models.JSONToViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Suporte\source\repos\PontoAll-2810\Views\Home\GeoExample.cshtml"
  
    ViewData["Title"] = "GeoExample";


#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1> GeoExample </h1>\r\n\r\n<ul>\r\n    <li>\r\n        País:");
#nullable restore
#line 15 "C:\Users\Suporte\source\repos\PontoAll-2810\Views\Home\GeoExample.cshtml"
        Write(Model.CountryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </li>\r\n    <li>\r\n        Estado:");
#nullable restore
#line 18 "C:\Users\Suporte\source\repos\PontoAll-2810\Views\Home\GeoExample.cshtml"
          Write(Model.RegionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </li>\r\n    <li>\r\n        Cidade:");
#nullable restore
#line 21 "C:\Users\Suporte\source\repos\PontoAll-2810\Views\Home\GeoExample.cshtml"
          Write(Model.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </li>\r\n    <li>\r\n        Latitude Endereço:");
#nullable restore
#line 24 "C:\Users\Suporte\source\repos\PontoAll-2810\Views\Home\GeoExample.cshtml"
                     Write(Model.Latitude);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </li>\r\n    <li>\r\n        Longitude Endereço:");
#nullable restore
#line 27 "C:\Users\Suporte\source\repos\PontoAll-2810\Views\Home\GeoExample.cshtml"
                      Write(Model.Longitude);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </li>\r\n</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PontoAll_2810.Models.JSONToViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
