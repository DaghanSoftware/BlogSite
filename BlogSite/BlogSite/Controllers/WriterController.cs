using BlogSite.Models;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Controllers
{
    public class WriterController : Controller
    {
        CityManager cm = new CityManager(new EfCityRepository());
        //[Authorize]
        //[AllowAnonymous]
        WriterManager wm = new WriterManager(new EfWriterRepository());
        private readonly UserManager<AppUser> _userManager;

        public WriterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [Authorize]
        public IActionResult Index()
        {
            var usermail = User.Identity.Name;
            ViewBag.v = usermail;

            Context c = new Context();
            var writerName = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterName).FirstOrDefault();
            ViewBag.v2 = writerName;
            return View();
        }

        public IActionResult WriterProfile()
        {
            return View();
        }

        public IActionResult WriterMail()
        {
            return View();
        }

        public IActionResult Test()
        {
            return View();
        }

        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }

        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }
        [HttpGet]
        public async Task<IActionResult>  WriterEditProfile()
        {
            //Context c = new Context();
            //var username = User.Identity.Name;

            //var usermail = c.Users.Where(x => x.UserName == username).Select(y => y.Email).FirstOrDefault();
            //UserManager userManager = new UserManager(new EfUserRepository());

            //var WriterId = c.Writers.Where(x => x.WriterMail == usermail).Select(y => y.WriterID).FirstOrDefault();

            //ViewBag.Cities = new SelectList(cm.GetList().ToList(), "CityId", "CityName");
            //var writervalues = wm.GetById(WriterId);

            //var id = c.Users.Where(x => x.Email == usermail).Select(y => y.Id).FirstOrDefault();
            //var values = userManager.GetById(id);

            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserUpdateViewModel model = new UserUpdateViewModel();
            model.mail = values.Email;
            model.namesurname = values.NameSurname;
            model.imageurl = values.ImageUrl;
            model.username = values.UserName;
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult>  WriterEditProfile(UserUpdateViewModel model)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            values.NameSurname = model.namesurname;
            values.ImageUrl = model.imageurl;
            values.Email = model.mail;
            var result = await _userManager.UpdateAsync(values);
            return RedirectToAction("WriterEditProfile", "Writer");
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterAdd()
        {
            ViewBag.Cities = new SelectList(cm.GetList().ToList(), "CityId", "CityName");
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage writer)
        {
            Writer w = new Writer();
            if (writer.WriterImage != null)
            {
                var extension = Path.GetExtension(writer.WriterImage.FileName);
                var newimagename = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles", newimagename);
                var stream = new FileStream(location, FileMode.Create);
                writer.WriterImage.CopyTo(stream);
                w.WriterImage = newimagename;
            }
            w.WriterMail = writer.WriterMail;
            w.WriterName = writer.WriterName;
            w.WriterPassword = writer.WriterPassword;
            w.WriterStatus = writer.WriterStatus;
            w.WriterAbout = writer.WriterAbout;
            w.CityId = writer.CityId;
            wm.TAdd(w);
            return RedirectToAction("Index","Dashboard");
        }

    }
}
