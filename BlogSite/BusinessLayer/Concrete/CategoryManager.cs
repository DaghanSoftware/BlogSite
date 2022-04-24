using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categorydal;
        public CategoryManager(ICategoryDal categorydal)
        {
            _categorydal = categorydal;
        }

        public Category GetById(int id)
        {
            return _categorydal.GetById(id);
        }

        public List<Category> GetList()
        {
            return _categorydal.GetListAll();
        }

        public void TAdd(Category t)
        {
            _categorydal.Insert(t);
        }

        public void TDelete(Category t)
        {
            _categorydal.Delete(t);
        }

        public void TUpdate(Category t)
        {
            _categorydal.Update(t);
        }

        //public void CategoryAdd(Category category)
        //{
        //    _categorydal.Insert(category);
        //}

        //public void CategoryDelete(Category category)
        //{
        //    _categorydal.Delete(category);

        //}

        //public void CategoryUpdate(Category category)
        //{
        //    _categorydal.Update(category);
        //}

        //public Category GetById(int id)
        //{
        //   return _categorydal.GetById(id);
        //}

        //public List<Category> GetList()
        //{
        //    return _categorydal.GetListAll();
        //}
    }
}
