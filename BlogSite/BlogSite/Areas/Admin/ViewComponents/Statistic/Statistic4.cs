using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic4:ViewComponent
    {
        Context c = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.GirisYapanAdminİsmi =c.Admins.Where(x => x.AdminID == 1).Select(y => y.Name).FirstOrDefault();
            ViewBag.GirisYapanAdminResmi = c.Admins.Where(x => x.AdminID == 1).Select(y => y.ImageURL).FirstOrDefault();
            ViewBag.GirisYapanAdminHakkinda = c.Admins.Where(x => x.AdminID == 1).Select(y => y.ShortDescription).FirstOrDefault();
            return View();
        }
    }
}
