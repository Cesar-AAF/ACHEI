using achei.comp.orcamentos.domain.Entities;
using achei.comp.orcamentos.domain.Interfaces.Applications;
using achei.comp.orcamentos.domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace achei.comp.orcamentos.repository.Repositories
{
    public abstract class Service<TRepository, TEntity> : IDisposable, IService<TEntity>
        where TEntity : Base
        where TRepository : IRepository<TEntity>
    {
        protected readonly TRepository _repository;

        public Service(TRepository repository)
        {
            _repository = repository;
        }

        public Task<TEntity> Delete(TEntity entity)
        {
            return _repository.Delete(entity);
        }

        public void Dispose()
        {
            if (_repository != null) {
                _repository.Dispose();
            }
            GC.SuppressFinalize(this);
        }

        public Task<TEntity> GetById(TEntity entity)
        {
            return _repository.GetById(entity);
        }

        public Task<IEnumerable<TEntity>> GetList(TEntity entity)
        {
            return _repository.GetList(entity);
        }

        public Task<TEntity> Insert(TEntity entity)
        {
            return _repository.Insert(entity);
        }

        public Task<TEntity> Update(TEntity entity)
        {
            return _repository.Update(entity);
        }
    }
}
