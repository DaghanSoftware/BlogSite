using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSite.ViewComponents.Category
{
    public class CategoryListDashboard:ViewComponent
    {
        CategoryManager cm = new CategoryManager(new EFCategoryRepository());
        public IViewComponentResult Invoke(int id)
        {
            var values = cm.GetList();
            return View(values);
        }
    }
}
