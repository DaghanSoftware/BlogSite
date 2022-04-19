using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager wm = new WriterManager(new EfWriterRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer writer,string WriterPasswordConfirm)
        {
            if (writer.WriterPassword==WriterPasswordConfirm)
            {
                writer.WriterStatus = true;
                writer.WriterAbout = "Deneme test";
                wm.WriterAdd(writer);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                return View();
            }
        }
    }
}
