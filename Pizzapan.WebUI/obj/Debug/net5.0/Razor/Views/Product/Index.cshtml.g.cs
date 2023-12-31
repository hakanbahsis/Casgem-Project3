#pragma checksum "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b8129b9f383c01a4ba9897aa97bb1866815a77c9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\_ViewImports.cshtml"
using Pizzapan.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\_ViewImports.cshtml"
using Pizzapan.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\_ViewImports.cshtml"
using Pizzapan.EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b8129b9f383c01a4ba9897aa97bb1866815a77c9", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cb30ed3a378aada80453f74f02322888ebfbe09", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int count = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Ürün Listesi</h1>
<table class=""table table-bordered"">
    <tr>
        <th>#</th>
        <th>Ürün Adı</th>
        <th>Ürün Açıklaması</th>
        <th>Ürün Fiyatı</th>
        <th>Ürün Kategori</th>
        <th>Sil</th>
        <th>Güncelle</th>
    </tr>
");
#nullable restore
#line 19 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Product\Index.cshtml"
     foreach (var item in Model)
    {
        count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Product\Index.cshtml"
           Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Product\Index.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Product\Index.cshtml"
           Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Product\Index.cshtml"
           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 27 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Product\Index.cshtml"
           Write(item.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 680, "\"", 725, 2);
            WriteAttributeValue("", 687, "/Product/DeleteProduct/", 687, 23, true);
#nullable restore
#line 28 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Product\Index.cshtml"
WriteAttributeValue("", 710, item.ProductId, 710, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 782, "\"", 827, 2);
            WriteAttributeValue("", 789, "/Product/UpdateProduct/", 789, 23, true);
#nullable restore
#line 29 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Product\Index.cshtml"
WriteAttributeValue("", 812, item.ProductId, 812, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Güncelle</a></td>\r\n        </tr>\r\n");
#nullable restore
#line 31 "C:\Users\Lenovo\source\repos\CasgemCoreProject\Pizzapan.WebUI\Views\Product\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<td><a href=\"/Product/AddProduct/\" class=\"btn btn-success\">Yeni Ürün Ekle</a></td>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
