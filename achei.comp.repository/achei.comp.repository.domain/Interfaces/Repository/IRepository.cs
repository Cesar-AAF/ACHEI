using achei.comp.repository.domain.Entity;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace achei.comp.repository.domain.Interfaces.Repository
{
    public interface IRepository<TEntity> : IDisposable
        where TEntity : Base
    {
        Task<TEntity> Insert(TEntity entity);

        Task<TEntity> Update(TEntity entity);

        Task<TEntity> Delete(TEntity entity);

        Task<TEntity> GetById(TEntity entity);

        Task<IEnumerable<TEntity>> Get(TEntity entity);
    }
}
