using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class WriterManager : IWriterServices
    {
        IWriterDal _writerdal;

        public WriterManager(IWriterDal writerdal)
        {
            _writerdal = writerdal;
        }

        public void WriterAdd(Writer writer)
        {
            _writerdal.Insert(writer);
        }

        public void WriterDelete(Writer writer)
        {
            throw new NotImplementedException();
        }

        public void WriterUpdate(Writer writer)
        {
            throw new NotImplementedException();
        }

        public Writer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Writer> GetList()
        {
            throw new NotImplementedException();
        }
    }
}
