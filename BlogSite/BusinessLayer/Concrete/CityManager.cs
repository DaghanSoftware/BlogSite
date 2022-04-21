using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CityManager : ICityService
    {
        ICityDal _cityDal;

        public CityManager(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }

        public City GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<City> GetList()
        {
            return _cityDal.GetListAll();
        }

        public void WriterAdd(City city)
        {
            throw new NotImplementedException();
        }

        public void WriterDelete(City city)
        {
            throw new NotImplementedException();
        }

        public void WriterUpdate(City city)
        {
            throw new NotImplementedException();
        }

    }
}
