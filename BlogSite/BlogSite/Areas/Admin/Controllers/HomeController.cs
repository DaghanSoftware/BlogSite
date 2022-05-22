using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.Areas.Admin.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult AdminIndex()
        {
            return View();
        }
    }
}
