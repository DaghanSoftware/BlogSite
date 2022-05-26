using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace BlogSite.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1:ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.ToplamBlogSayisi = bm.GetList().Count();
            ViewBag.ContactCount = c.Contacts.Count();
            ViewBag.ToplamYorumSayisi = c.Comments.Count();

            string api = "b68001dfd92bafa7d838557fd13a975e";
            string connection= "https://api.openweathermap.org/data/2.5/weather?q=Kocaeli&mode=xml&lang=tr&units=metric&appid="+api;
            XDocument document = XDocument.Load(connection);
            ViewBag.Sicaklik = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            ViewBag.Sehir = document.Descendants("city").ElementAt(0).Attribute("name").Value;
            return View();
        }
    }
}
