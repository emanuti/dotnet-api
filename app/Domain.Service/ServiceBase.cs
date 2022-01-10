using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Core.Interfaces.Repositories;
using Domain.Core.Interfaces.Services;

namespace Domain.Service
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repo;
        public ServiceBase(IRepositoryBase<TEntity> repo)
        {
            this._repo = repo;
        }
        public void Add(TEntity obj) {
            _repo.Add(obj);
        }

        public void Update(TEntity obj) {
            _repo.Update(obj);
        }
        public void Remove(TEntity obj) {
            _repo.Remove(obj);
        }
        public IEnumerable<TEntity> GetAll() {
            return _repo.GetAll();
        }

        public TEntity GetById(int id) {
            return _repo.GetById(id);
        }
    }
}