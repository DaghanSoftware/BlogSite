using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.ViewComponents.Writer
{
    
    public class WriterAboutOnDashBoard:ViewComponent
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        Context c = new Context();

        public IViewComponentResult Invoke(int id)
        {
            //var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var username = User.Identity.Name;
            ViewBag.GirisYapanKullanici = username;

            var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            var WriterId = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();

            var values = wm.GetWriterListID(WriterId);
            return View(values);
        }
    }
}
