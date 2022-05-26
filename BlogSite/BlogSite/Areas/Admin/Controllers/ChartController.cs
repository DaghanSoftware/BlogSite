using BlogSite.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CategoryChart()
        {
            List<CategoryClass> list = new List<CategoryClass>();
            list.Add(new CategoryClass { categoryname = "Teknoloji", categorycount = 10 });
            list.Add(new CategoryClass { categoryname = "Yazılım", categorycount = 20 });
            list.Add(new CategoryClass { categoryname = "Haberler", categorycount = 30 });
            return Json(new { jsonlist = list });

        }
    }
}
