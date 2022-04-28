using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        CityManager cm = new CityManager(new EfCityRepository());
        public IActionResult Index()
        {
            ViewBag.Cities = new SelectList(cm.GetList().ToList(), "CityId", "CityName");
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer writer,string WriterPasswordConfirm)
        {
            WriterValidator validationRules = new WriterValidator();
            ValidationResult result = validationRules.Validate(writer);
            if (result.IsValid)
            {
                if (writer.WriterPassword == WriterPasswordConfirm)
                {
                    writer.WriterStatus = true;
                    writer.WriterAbout = "Deneme test";
                    wm.TAdd(writer);
                    return RedirectToAction("Index", "Blog");
                }
                else
                {
                    return View();
                }
                
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName,item.ErrorMessage);
                }
                
            }
            return View();

        }
    }
}
