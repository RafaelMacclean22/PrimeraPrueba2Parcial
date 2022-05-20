﻿using PepitoSchool.Domain.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepreciationDBApp.Domain.Interfaces
{
    public interface IRepository<T>
    {
        void Create(T t);
        int Update(T t);
        bool Delete(T t);
        List<T> GetAll();
        
    }
}
