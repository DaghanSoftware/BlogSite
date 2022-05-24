using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic2 : ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            @ViewBag.SonEklenenBlogAdı = c.Blogs.OrderByDescending(x=>x.BlogID).Select(x => x.BlogTitle).Take(1).FirstOrDefault();
            return View();
        }
    }
}
