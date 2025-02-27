using EpiApp.Domain.Base;
using EpiApp.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace EpiApp.Repository.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity>
        where TEntity : BaseEntity<int>
    {
        private readonly MySqlServerContext _context;

        public BaseRepository(MySqlServerContext context)
        {
            _context = context;
        }

        public void AttachObject(object obj)
        {
            _context.Attach(obj);
        }

        public void ClearChangeTracker()
        {
            _context.ChangeTracker.Clear();
        }
        public void Insert(TEntity entity)
        {
                _context.Set<TEntity>().Add(entity);
                _context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();            
        }

        public void Delete(object id)
        {
            _context.Set<TEntity>().Remove(Select(id));
            _context.SaveChanges();
        }


        public IList<TEntity> Select(bool tracking = true, IList<string>? includes = null)
        {
            IQueryable<TEntity> dbContext;
            if (tracking)
            {
                dbContext = _context.Set<TEntity>().AsQueryable();
            } 
            else
            {
                dbContext = _context.Set<TEntity>().AsNoTracking().AsQueryable();
            }
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    dbContext.Include<TEntity>(include);
                }
            }
            return dbContext.ToList();
        }

        public TEntity Select(object id, bool tracking = true, IList<string>? includes = null)
        {
            IQueryable<TEntity> dbContext;
            if (tracking)
            {
                dbContext = _context.Set<TEntity>().AsQueryable();
            }
            else
            {
                dbContext = _context.Set<TEntity>().AsNoTracking().AsQueryable();
            }
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    dbContext.Include<TEntity>(include);
                }
            }
            return dbContext.FirstOrDefault(x => x.Id == (int)id);
        }
    }
}
