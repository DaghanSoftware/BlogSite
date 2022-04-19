using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWriterServices
    {
        void CategoryAdd(Writer writer);

        void CategoryDelete(Writer writer);

        void CategoryUpdate(Writer writer);

        List<Writer> GetList();

        Category GetById(int id);
    }
}
