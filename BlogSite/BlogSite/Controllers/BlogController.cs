using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ValidationResult = FluentValidation.Results.ValidationResult;

namespace BlogSite.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }

        public IActionResult BlogReadAll(int id)
        {
            ViewBag.BlogId = id;
            var values = bm.GetBlogById(id);
            return View(values);
        }

        public IActionResult BlogListByWriter()
        {
            var values = bm.GetListWithCateogryByWriterBm(1);
            return View(values);
        }

        [HttpGet]
        public IActionResult BlogAdd()
        {
            CategoryManager cm = new CategoryManager(new EFCategoryRepository());
            List<SelectListItem> categoryvalues= (from x in cm.GetList()
                                                  select new SelectListItem
                                                  { 
                                                      Text=x.CategoryName,
                                                      Value=x.CategoryID.ToString()
                                                  }).ToList();
            ViewBag.cv = categoryvalues;
            return View();
        }

        [HttpPost]
        public IActionResult BlogAdd(Blog p)
        {
            BlogValidator validationRules = new BlogValidator();
            ValidationResult result = validationRules.Validate(p);
            if (result.IsValid)
            {
                    p.BlogStatus = "True";
                    p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                    p.WriterID = 1;
                    bm.TAdd(p);
                    return RedirectToAction("BlogListByWriter", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

            }
            return View();
        }

    }
}
