using achei.comp.prestador.domain.Entities;
using achei.comp.prestador.domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace achei.comp.prestador.repository.Repositories
{
    public abstract class Repository<TContext, TEntity> : IDisposable, IRepository<TEntity>
        where TEntity : Base
        where TContext : DbContext
    {
        protected TContext _context;

        public Repository(TContext context)
        {
            try {
                _context = context;
                _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            }
            catch (Exception ex) { 
                throw ex;
            }
           
        }

        public async Task<TEntity> Delete(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Deleted;
            await _context.SaveChangesAsync();
            return entity;
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<TEntity> GetById(TEntity entity)
        {
            return await _context.Set<TEntity>().AsNoTracking().FirstOrDefaultAsync(e => e.Id.Equals(entity.Id));
        }

        public async Task<IEnumerable<TEntity>> GetList(TEntity entity)
        {
            return await _context.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public async Task<TEntity> Insert(TEntity entity)
        {
            if (null == entity.DataCriacao)
                entity.DataCriacao = DateTime.Now;

            _context.Set<TEntity>().Add(entity);
            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return entity;
        }
    }
}
