using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Controllers
{
    public class DashBoardController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            Context c = new Context();
            ViewBag.ToplamBlogSayisi = c.Blogs.Count().ToString();
            ViewBag.YazarınBlogSayısı = c.Blogs.Where(x=>x.WriterID==1).Count().ToString();
            ViewBag.ToplamKategoriSayısı = c.Blogs.Count().ToString();
            return View();
        }
    }
}
