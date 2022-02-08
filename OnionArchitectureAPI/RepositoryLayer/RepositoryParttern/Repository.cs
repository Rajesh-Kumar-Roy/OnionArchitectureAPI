using DomainLayer.Models.DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RepositoryLayer.RepositoryParttern
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        #region  Properties

        private readonly ApplicationDbContext _applicationDbContext;
        private DbSet<T> entities;

        #endregion

        #region Constructor

        public Repository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            entities = _applicationDbContext.Set<T>();
        }

        #endregion
        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public T Get(int id)
        {
            return entities.SingleOrDefault(x => x.Id == id);
        }

        public void Insert(T entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");

            entities.Add(entity);
            _applicationDbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            entities.Update(entity);
            _applicationDbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            entities.Remove(entity);
            _applicationDbContext.SaveChanges();
        }

        public void Remove(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }

            entities.Remove(entity);
        }

        public void SaveChange()
        {
            _applicationDbContext.SaveChanges();
        }
    }
}
