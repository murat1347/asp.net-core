#pragma checksum "C:\Users\Murat\source\repos\ProjeCore\ProjeCore\Views\Default\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0eb0bf31da56b3e30d1c5631d14ed9487c600693"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Index), @"mvc.1.0.view", @"/Views/Default/Index.cshtml")]
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
#line 1 "C:\Users\Murat\source\repos\ProjeCore\ProjeCore\Views\_ViewImports.cshtml"
using ProjeCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Murat\source\repos\ProjeCore\ProjeCore\Views\Default\Index.cshtml"
using ProjeCore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0eb0bf31da56b3e30d1c5631d14ed9487c600693", @"/Views/Default/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f6887fc2a081498e457a98abd035f4ecf5faaf7", @"/Views/_ViewImports.cshtml")]
    public class Views_Default_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProjeCore.Models.Birim>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Murat\source\repos\ProjeCore\ProjeCore\Views\Default\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>Id</th>>\r\n        <th>Birim</th>\r\n        <th>Sil</th>>\r\n        <th>Güncelle</th>>\r\n        <th>Detaylar</th>>\r\n    </tr>\r\n");
#nullable restore
#line 17 "C:\Users\Murat\source\repos\ProjeCore\ProjeCore\Views\Default\Index.cshtml"
     foreach (var x in Model)
    {

    

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 22 "C:\Users\Murat\source\repos\ProjeCore\ProjeCore\Views\Default\Index.cshtml"
           Write(x.BirimId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 23 "C:\Users\Murat\source\repos\ProjeCore\ProjeCore\Views\Default\Index.cshtml"
           Write(x.BirimAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>>\r\n            <th><a");
            BeginWriteAttribute("href", " href=\"", 484, "\"", 519, 2);
            WriteAttributeValue("", 491, "/default/birimsil/", 491, 18, true);
#nullable restore
#line 24 "C:\Users\Murat\source\repos\ProjeCore\ProjeCore\Views\Default\Index.cshtml"
WriteAttributeValue("", 509, x.BirimId, 509, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></th>\r\n            <th><a");
            BeginWriteAttribute("href", " href=\"", 576, "\"", 613, 2);
            WriteAttributeValue("", 583, "/default/birimgetir/", 583, 20, true);
#nullable restore
#line 25 "C:\Users\Murat\source\repos\ProjeCore\ProjeCore\Views\Default\Index.cshtml"
WriteAttributeValue("", 603, x.BirimId, 603, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a></th>>\r\n            <th><a");
            BeginWriteAttribute("href", " href=\"", 677, "\"", 714, 2);
            WriteAttributeValue("", 684, "/default/birimdetay/", 684, 20, true);
#nullable restore
#line 26 "C:\Users\Murat\source\repos\ProjeCore\ProjeCore\Views\Default\Index.cshtml"
WriteAttributeValue("", 704, x.BirimId, 704, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default\" style=\"background-color: yellow\">Detaylar</a></th>>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 29 "C:\Users\Murat\source\repos\ProjeCore\ProjeCore\Views\Default\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Birim/yenibirim/\" class=\"btn btn-danger\" style=\"background-color: aqua\">Yeni Departman</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProjeCore.Models.Birim>> Html { get; private set; }
    }
}
#pragma warning restore 1591