using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface ICityService
    {
        void WriterAdd(City city);

        void WriterDelete(City city);

        void WriterUpdate(City city);

        List<City> GetList();

        City GetById(int id);
    }
}
