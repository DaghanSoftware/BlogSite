using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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
        public IViewComponentResult Invoke(int id)
        {
            var values = wm.GetWriterListID(1);
            return View(values);
        }
    }
}
