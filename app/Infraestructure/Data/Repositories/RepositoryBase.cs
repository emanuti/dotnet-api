using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Domain.Core.Interfaces.Repositories;

namespace Infraestructure.Data.Repositories
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        private readonly SqlContext _sqlContext;
        
        public RepositoryBase(SqlContext sqlContext)
        {
            this._sqlContext = sqlContext;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _sqlContext.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return _sqlContext.Set<TEntity>().Find(id);
        }

        public void Add(TEntity obj) 
        {
            try {
                _sqlContext.Set<TEntity>().Add(obj);
                _sqlContext.SaveChanges();
            } catch (Exception e) {
                
                throw e;
            }
        }
        public void Update(TEntity obj)
        {
            try {
                _sqlContext.Entry(obj).State = EntityState.Modified;
                _sqlContext.SaveChanges();
            } catch (Exception e) {
                throw e;
            }
        }

        public void Remove(TEntity obj)
        {
            try {
                _sqlContext.Set<TEntity>().Remove(obj);
                _sqlContext.SaveChanges();
            } catch (Exception e) {
                throw e;
            }
        }
    }
}