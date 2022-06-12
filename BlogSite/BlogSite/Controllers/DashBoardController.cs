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
        Context c = new Context();
        public IActionResult Index()
        {

            var username = User.Identity.Name;
            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var WriterId = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();
       
            ViewBag.ToplamBlogSayisi = c.Blogs.Count().ToString();
            ViewBag.YazarınBlogSayısı = c.Blogs.Where(x=>x.WriterID== WriterId).Count().ToString();
            ViewBag.ToplamKategoriSayısı = c.Blogs.Count().ToString();
            return View();
        }
    }
}
