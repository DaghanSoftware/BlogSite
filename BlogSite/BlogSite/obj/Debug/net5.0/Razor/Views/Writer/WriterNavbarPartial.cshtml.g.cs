#pragma checksum "C:\Users\STElb\OneDrive\Belgeler\GitHub\BlogSite\BlogSite\BlogSite\Views\Writer\WriterNavbarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eddb4c9a81980e529c63ec820a420c8b8cfd1866"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Writer_WriterNavbarPartial), @"mvc.1.0.view", @"/Views/Writer/WriterNavbarPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eddb4c9a81980e529c63ec820a420c8b8cfd1866", @"/Views/Writer/WriterNavbarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e22ed595629094cbd066d5e50ea9c18160955b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Writer_WriterNavbarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav class=""sidebar sidebar-offcanvas"" id=""sidebar"">
    <ul class=""nav"">
        <li class=""nav-item nav-profile"">
            <a href=""#"" class=""nav-link"">
                <div class=""nav-profile-image"">
                    <img src=""/writer/assets/images/faces/face1.jpg"" alt=""profile"">
                    <span class=""login-status online""></span>
                    <!--change to offline or busy as needed-->
                </div>
                <div class=""nav-profile-text d-flex flex-column"">
                    <span class=""font-weight-bold mb-2"">Semih Dağhan</span>
                    <span class=""text-secondary text-small"">Yazılım Mühendisi</span>
                </div>
                <i class=""mdi mdi-bookmark-check text-success nav-profile-badge""></i>
            </a>
        </li>
        <div class=""border-bottom"">
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/DashBoard/Index"">
                <span class=""menu-title"">Dashboard</span>
                <i");
            WriteLiteral(@" class=""mdi mdi-home menu-icon""></i>
            </a>
        </li>
        </div>

        <div class=""border-bottom"">
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/WriterEditProfile"">
                <span class=""menu-title"">Profilim</span>
                <i class=""mdi mdi-contacts menu-icon""></i>
            </a>
        </li>
        </div>

        <div class=""border-bottom"">
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Blog/BlogListByWriter"">
                <span class=""menu-title"">Bloglarım</span>
                <i class=""mdi mdi-format-list-bulleted menu-icon""></i>
            </a>
        </li>
        </div>

        <div class=""border-bottom"">
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Blog/BlogAdd"">
                <span class=""menu-title"">Yeni Blog</span>
                <i class=""mdi mdi-chart-bar menu-icon""></i>
            </a>
        </li>
        </div>

        <div class=""bor");
            WriteLiteral(@"der-bottom"">
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Message/InBox"">
                <span class=""menu-title"">Gelen Mesajlar</span>
                <i class=""mdi mdi-message menu-icon""></i>
            </a>
        </li>
        </div>

        <div class=""border-bottom"">
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Message/SendBox"">
                <span class=""menu-title"">Giden Mesajlar</span>
                <i class=""mdi mdi-message menu-icon""></i>
            </a>
        </li>
        </div>

        <div class=""border-bottom"">
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Notification/AllNotification"">
                <span class=""menu-title"">Bildirimler</span>
                <i class=""mdi mdi-notification-clear-all menu-icon""></i>
            </a>
        </li>
        </div>

        <div class=""border-bottom"">
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Blog/Index"">
   ");
            WriteLiteral(@"             <span class=""menu-title"">Siteye Git</span>
                <i class=""menu-arrow""></i>
                <i class=""mdi mdi-blogger menu-icon""></i>
            </a>
        </li>
        </div>

        <div class=""border-bottom"">
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Writer/WriterEditProfile"">
                <span class=""menu-title"">Ayarlar</span>
                <i class=""menu-arrow""></i>
                <i class=""mdi mdi-settings menu-icon""></i>
            </a>
        </li>
        </div>

        <div class=""border-bottom"">
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Login/LogOut"">
                <span class=""menu-title"">Çıkış Yap</span>
                <i class=""menu-arrow""></i>
                <i class=""mdi mdi-settings menu-icon""></i>
            </a>
        </li>
        </div>

        <li class=""nav-item sidebar-actions"">
            <span class=""nav-link"">
                <button class=""btn btn-block ");
            WriteLiteral("btn-lg btn-gradient-primary mt-4\"><i class=\"mdi mdi-logout-variant menu-icon\" href=\"/Login/LogOut\"></i> Çıkış Yap </button>\r\n            </span>\r\n        </li>\r\n    </ul>\r\n</nav>");
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
