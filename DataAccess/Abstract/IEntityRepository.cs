﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;


namespace DataAccess.Abstract
{
    //generic constraint
    //class : referans tip olabilir
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
        List<T> GetAll(Expression<Func<T, bool>>filter=null); //GetAll hespini getir demektir    
        T Get(Expression<Func<T, bool>>filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
