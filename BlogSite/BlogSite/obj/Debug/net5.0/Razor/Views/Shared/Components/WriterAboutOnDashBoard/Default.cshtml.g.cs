#pragma checksum "C:\Users\STElb\OneDrive\Belgeler\GitHub\BlogSite\BlogSite\BlogSite\Views\Shared\Components\WriterAboutOnDashBoard\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a56b98ea89091f7fb8f257ef1a291deaa0b0f33"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterAboutOnDashBoard_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterAboutOnDashBoard/Default.cshtml")]
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
#line 1 "C:\Users\STElb\OneDrive\Belgeler\GitHub\BlogSite\BlogSite\BlogSite\Views\_ViewImports.cshtml"
using BlogSite;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\STElb\OneDrive\Belgeler\GitHub\BlogSite\BlogSite\BlogSite\Views\_ViewImports.cshtml"
using BlogSite.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\STElb\OneDrive\Belgeler\GitHub\BlogSite\BlogSite\BlogSite\Views\Shared\Components\WriterAboutOnDashBoard\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a56b98ea89091f7fb8f257ef1a291deaa0b0f33", @"/Views/Shared/Components/WriterAboutOnDashBoard/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e22ed595629094cbd066d5e50ea9c18160955b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_WriterAboutOnDashBoard_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Writer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h4 class=\"card-title\">Yazar Hakkında</h4>\r\n                <h1>Selam ");
#nullable restore
#line 8 "C:\Users\STElb\OneDrive\Belgeler\GitHub\BlogSite\BlogSite\BlogSite\Views\Shared\Components\WriterAboutOnDashBoard\Default.cshtml"
                     Write(ViewBag.GirisYapanKullanici);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                <div class=\"d-flex mt-5 align-items-top\">\r\n");
#nullable restore
#line 10 "C:\Users\STElb\OneDrive\Belgeler\GitHub\BlogSite\BlogSite\BlogSite\Views\Shared\Components\WriterAboutOnDashBoard\Default.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <img src=\"/writer/assets/images/faces/face3.jpg\" class=\"img-sm rounded-circle mr-3\" alt=\"image\">\r\n                        <div class=\"mb-0 flex-grow\">\r\n                            <h5 class=\"mr-2 mb-2\">");
#nullable restore
#line 14 "C:\Users\STElb\OneDrive\Belgeler\GitHub\BlogSite\BlogSite\BlogSite\Views\Shared\Components\WriterAboutOnDashBoard\Default.cshtml"
                                             Write(item.WriterName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 14 "C:\Users\STElb\OneDrive\Belgeler\GitHub\BlogSite\BlogSite\BlogSite\Views\Shared\Components\WriterAboutOnDashBoard\Default.cshtml"
                                                                Write(item.WriterMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"mb-0 font-weight-light\">");
#nullable restore
#line 15 "C:\Users\STElb\OneDrive\Belgeler\GitHub\BlogSite\BlogSite\BlogSite\Views\Shared\Components\WriterAboutOnDashBoard\Default.cshtml"
                                                         Write(item.WriterAbout);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n");
#nullable restore
#line 17 "C:\Users\STElb\OneDrive\Belgeler\GitHub\BlogSite\BlogSite\BlogSite\Views\Shared\Components\WriterAboutOnDashBoard\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"ml-auto\">\r\n                        <i class=\"mdi mdi-heart-outline text-muted\"></i>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Writer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
