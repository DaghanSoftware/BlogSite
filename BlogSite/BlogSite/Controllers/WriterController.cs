using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Controllers
{
    public class WriterController : Controller
    {
        //[Authorize]
        //[AllowAnonymous]
        WriterManager wm = new WriterManager(new EfWriterRepository());
        public IActionResult Index()
        {
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
        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }
        [AllowAnonymous]
        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }

        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }
        
        CityManager cm = new CityManager(new EfCityRepository());
        [AllowAnonymous]
        public IActionResult WriterEditProfile()
        {
            ViewBag.Cities = new SelectList(cm.GetList().ToList(), "CityId", "CityName");
            var writervalues = wm.GetById(1);
            return View(writervalues);
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterEditProfile(Writer p,string WriterPasswordConfirm)
        {
            WriterValidator wl = new WriterValidator();
            ValidationResult result = wl.Validate(p);
            if (result.IsValid)
            {
                if (p.WriterPassword == WriterPasswordConfirm)
                {
                    wm.TUpdate(p);
                    return RedirectToAction("WriterEditProfile", "Writer");
                } 
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                
            }
            ViewBag.Cities = new SelectList(cm.GetList().ToList(), "CityId", "CityName");
            return View();

        }
    }
}
