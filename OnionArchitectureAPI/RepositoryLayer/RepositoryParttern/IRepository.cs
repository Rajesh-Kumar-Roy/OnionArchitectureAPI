﻿using DomainLayer.Models.DomainLayer.Models;
using System.Collections.Generic;

namespace RepositoryLayer.RepositoryParttern
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T Get(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Remove(T entity);
        void SaveChange();
    }
}
