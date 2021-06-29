using Business.Core.Model;
using Business.Core.Repositories;
using Infra.Data.DbApplications;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Infra.Data.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        protected readonly DbApplication _db;
        protected readonly DbSet<TEntity> _dbSet;

        protected Repository(DbApplication db)
        {
            _db = db;
            _dbSet = _db.Set<TEntity>();
        }

        public async Task Adicionar(TEntity entity)
        {
            _dbSet.Add(entity);
            await _db.SaveChangesAsync();
        }

        public async Task Atualizar(TEntity entity)
        {
            _db.Entry<TEntity>(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();

        }

        public async Task Remover(Guid id)
        {
            _db.Entry(new TEntity { Id = id }).State = EntityState.Deleted;
            await _db.SaveChangesAsync();
        }

        public async Task<TEntity> ObterPorId(Guid id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<List<TEntity>> ObterTodos()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public void Dispose()
        {
            _db?.Dispose();
        }

    }
}
