#pragma checksum "C:\Users\STElb\OneDrive\Belgeler\GitHub\BlogSite\BlogSite\BlogSite\Views\Admin\AdminNavbarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71824e60fe3d37d67ad10c5befa061e593cce260"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_AdminNavbarPartial), @"mvc.1.0.view", @"/Views/Admin/AdminNavbarPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71824e60fe3d37d67ad10c5befa061e593cce260", @"/Views/Admin/AdminNavbarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e22ed595629094cbd066d5e50ea9c18160955b9", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_AdminNavbarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<nav class=""navbar-default navbar-static-side"" role=""navigation"">
    <div class=""sidebar-collapse"">
        <ul class=""nav metismenu"" id=""side-menu"">
            <li class=""nav-header"">
                <div class=""dropdown profile-element"">
                    <img alt=""image"" class=""rounded-circle"" src=""/inspinia-gh-pages/img/profile_small.jpg"" />
                    <a data-toggle=""dropdown"" class=""dropdown-toggle"" href=""#"">
                        <span class=""block m-t-xs font-bold"">Semih Dağhan</span>
                        <span class=""text-muted text-xs block"">Software Developer <b class=""caret""></b></span>
                    </a>
                    <ul class=""dropdown-menu animated fadeInRight m-t-xs"">
                        <li><a class=""dropdown-item"" href=""profile.html"">Profile</a></li>
                        <li><a class=""dropdown-item"" href=""contacts.html"">Contacts</a></li>
                        <li><a class=""dropdown-item"" href=""mailbox.html"">Mailbox</a></li>
              ");
            WriteLiteral(@"          <li class=""dropdown-divider""></li>
                        <li><a class=""dropdown-item"" href=""login.html"">Logout</a></li>
                    </ul>
                </div>
                <div class=""logo-element"">
                    IN+
                </div>
            </li>
            <li>
                <a href=""/Admin/Widget/Index""><i class=""fa fa-th-large""></i> <span class=""nav-label"">Dashboard</span>  </a>
            </li>
            <li>
                <a href=""/Admin/Chart/Index""><i class=""fa fa-bar-chart-o""></i> <span class=""nav-label"">Grafikler</span>  </a>
            </li>
            <li>
                <a href=""mailbox.html""><i class=""fa fa-envelope""></i> <span class=""nav-label"">Mesajlar </span><span class=""label label-warning float-right"">0/0</span></a>
                <ul class=""nav nav-second-level collapse"">
                    <li><a href=""/Admin/AdminMessage/Inbox/"">Gelen Kutusu</a></li>
                    <li><a href=""mail_detail.html"">Giden Kutusu</a>");
            WriteLiteral(@"</li>
                    <li><a href=""mail_compose.html"">Yeni Mesaj Oluştur</a></li>
                </ul>
            </li>
            <li>
                <a href=""/Admin/Widget/Index""><i class=""fa fa-pie-chart""></i> <span class=""nav-label"">Metrikler</span>  </a>
            </li>
            <li>
                <a href=""/Admin/Category/AdminCategoryList""><i class=""fa fa-group""></i> <span class=""nav-label"">Kategoriler</span>  </a>
            </li>
            <li>
                <a href=""metrics.html""><i class=""fa fa-bookmark""></i> <span class=""nav-label"">Bloglar</span>  </a>
            </li>
            <li>
                <a href=""metrics.html""><i class=""fa fa-comment""></i> <span class=""nav-label"">Yorumlar</span>  </a>
            </li>
            <li>
                <a href=""/Admin/Writer/Index""><i class=""fa fa-user""></i> <span class=""nav-label"">Yazarlar</span>  </a>
            </li>
            <li>
                <a href=""metrics.html""><i class=""fa fa-info""></i> <span cla");
            WriteLiteral(@"ss=""nav-label"">Ayarlar</span>  </a>
            </li>
            <li>
                <a href=""metrics.html""><i class=""fa fa-diamond""></i> <span class=""nav-label"">Bildirimler</span>  </a>
            </li>
            <li>
                <a href=""metrics.html""><i class=""fa fa-phone""></i> <span class=""nav-label"">İletişim</span>  </a>
            </li>
            <li>
                <a href=""metrics.html""><i class=""fa fa-book""></i> <span class=""nav-label"">Hakkımızda</span>  </a>
            </li>
            <li>
                <a href=""/Admin/Blog/BlogListExcel""><i class=""fa fa-flask""></i> <span class=""nav-label"">Excel İşlemleri</span></a>
            </li>
            <li>
                <a href=""/Admin/Blog/BlogListExcel""><i class=""fa fa-close""></i> <span class=""nav-label"">Çıkış Yap</span></a>
            </li>
        </ul>

    </div>
</nav>");
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
