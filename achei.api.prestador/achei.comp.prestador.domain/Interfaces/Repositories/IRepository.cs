using achei.comp.prestador.domain.Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace achei.comp.prestador.domain.Interfaces.Repositories
{
    public interface IRepository<TEntity> : IDisposable
        where TEntity : Base
    {
        Task<TEntity> Insert(TEntity entity);

        Task<TEntity> Update(TEntity entity);

        Task<TEntity> Delete(TEntity entity);

        Task<TEntity> GetById(TEntity entity);

        Task<IEnumerable<TEntity>> GetList(TEntity entity);
    }
}
