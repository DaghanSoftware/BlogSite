﻿using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IWriterServices
    {
        void WriterAdd(Writer writer);

        void WriterDelete(Writer writer);

        void WriterUpdate(Writer writer);

        List<Writer> GetList();

        Writer GetById(int id);
    }
}
