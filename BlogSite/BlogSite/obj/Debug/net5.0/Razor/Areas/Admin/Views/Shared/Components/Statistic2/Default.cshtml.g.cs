#pragma checksum "C:\Users\STElb\OneDrive\Belgeler\GitHub\BlogSite\BlogSite\BlogSite\Areas\Admin\Views\Shared\Components\Statistic2\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04371084bcb50e8b091a3346b6335cd427f488e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_Statistic2_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/Statistic2/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04371084bcb50e8b091a3346b6335cd427f488e6", @"/Areas/Admin/Views/Shared/Components/Statistic2/Default.cshtml")]
    public class Areas_Admin_Views_Shared_Components_Statistic2_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-6"">
        <div class=""widget navy-bg no-padding"">
            <div class=""p-m"">
                <h1 class=""m-xs"">Dashboard</h1>

                <small>Projemizin bu panelinde Admin işlemleri bir Area yapısı üzerinden geerçekleşmektedir. Sol Tarafta yer alan sidebardan yardım menüsüne ulaşıp takıldığınız noktalarla ilgili destek alabilirisiniz.</small>
            </div>
            <div class=""flot-chart"">
                <div class=""flot-chart-content"" id=""flot-chart1""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3"">
        <div class=""widget lazur-bg no-padding"">
            <div class=""p-m"">

                <h3 class=""font-bold no-margins"">
                    Son Eklenen Blog İsmi
                </h3>
                <small>");
#nullable restore
#line 22 "C:\Users\STElb\OneDrive\Belgeler\GitHub\BlogSite\BlogSite\BlogSite\Areas\Admin\Views\Shared\Components\Statistic2\Default.cshtml"
                  Write(ViewBag.SonEklenenBlogAdı);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</small>
            </div>
            <div class=""flot-chart"">
                <div class=""flot-chart-content"" id=""flot-chart2""></div>
            </div>
        </div>
    </div>
    <div class=""col-lg-3"">
        <div class=""widget yellw-bg no-padding"">
            <div class=""p-m"">
                <h1 class=""m-xs"">₺ 50,992</h1>

                <h2 class=""font-bold no-margins"">
                    Blog Site Kazancı.
                </h2>
                <h4>Reklamlar, Ürün Tanıtımları, Anlaşmalar</h4>
            </div>
            <div class=""flot-chart"">
                <div class=""flot-chart-content"" id=""flot-chart3""></div>
            </div>
        </div>
    </div>
</div>");
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
