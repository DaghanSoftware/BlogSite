#pragma checksum "C:\Users\STElb\OneDrive\Belgeler\GitHub\BlogSite\BlogSite\BlogSite\Views\Shared\Components\CategoryList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29ca9d91a85bbdc6a3d9f68f2a4b15b2833a085d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_CategoryList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"29ca9d91a85bbdc6a3d9f68f2a4b15b2833a085d", @"/Views/Shared/Components/CategoryList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e22ed595629094cbd066d5e50ea9c18160955b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_CategoryList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"tech-btm\">\r\n    <h4>Categories</h4>\r\n    <ul class=\"list-group single\">\r\n");
#nullable restore
#line 5 "C:\Users\STElb\OneDrive\Belgeler\GitHub\BlogSite\BlogSite\BlogSite\Views\Shared\Components\CategoryList\Default.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li href=\"#\" class=\"list-group-item d-flex justify-content-between align-items-center\">\r\n                ");
#nullable restore
#line 8 "C:\Users\STElb\OneDrive\Belgeler\GitHub\BlogSite\BlogSite\BlogSite\Views\Shared\Components\CategoryList\Default.cshtml"
           Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span href=\"#\" class=\"badge badge-primary badge-pill\">0</span>\r\n            </li>\r\n");
#nullable restore
#line 11 "C:\Users\STElb\OneDrive\Belgeler\GitHub\BlogSite\BlogSite\BlogSite\Views\Shared\Components\CategoryList\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
