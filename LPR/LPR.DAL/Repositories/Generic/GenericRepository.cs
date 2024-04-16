using LPR.DAL.CoreDB;
using LPR.DAL.Interfaces.IRepositories.IGeneric;
using Microsoft.EntityFrameworkCore;

namespace LPR.DAL.Repositories.Generic
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class 
    {

        public LrpContext dbContext;
        public GenericRepository(LrpContext context)
        {
            this.dbContext = context;
            this.dbContext.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }


        public virtual List<T> GetAll()
        {
            List<T> collection = dbContext.Set<T>().ToList();
            return collection;
        }

        public async Task<List<T>> GetBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            List<T> collection = await dbContext.Set<T>().Where(predicate).AsNoTracking().ToListAsync();
            return collection;
        }

        public async Task<T> GetSingleBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            T entity = await dbContext.Set<T>().Where(predicate).FirstOrDefaultAsync();
            return entity;
        }

        public T GetSingleNonTrackingBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {

            T entity = dbContext.Set<T>().Where(predicate).AsNoTracking().FirstOrDefault();
            return entity;
        }

        public virtual List<T> GetAllNonTracking()
        {

            List<T> collection = dbContext.Set<T>().AsNoTracking().ToList();
            return collection;
        }

        public List<T> GetNonTrackingBy(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {

            List<T> collection = dbContext.Set<T>().Where(predicate).AsNoTracking().ToList();
            return collection;
        }

        public async Task<int> GetCount(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return await dbContext.Set<T>().CountAsync(predicate);
        }


        public virtual async Task Add(T entity)
        {
            await dbContext.Set<T>().AddAsync(entity);
        }

        public virtual void Delete(T entity)
        {
            dbContext.Set<T>().Remove(entity);
        }

        public virtual void Edit(T entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual void Detach(T entity)
        {
            dbContext.Entry(entity).State = EntityState.Detached;
        }

        public virtual void DetachAll(List<T> entities)
        {
            if (entities != null)
            {
                foreach (var changeEntry in entities)
                {
                    dbContext.Entry(changeEntry).State = EntityState.Detached;
                }
            }
        }

        public virtual void Save()
        {
            dbContext.SaveChanges();
        }
    }
}
