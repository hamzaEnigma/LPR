using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LPR.DAL.Interfaces.IRepositories.IGeneric
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetAll();
        List<T> GetAllNonTracking();
        Task<List<T>> GetBy(Expression<Func<T, bool>> predicate);
        List<T> GetNonTrackingBy(Expression<Func<T, bool>> predicate);
        Task<T> GetSingleBy(Expression<Func<T, bool>> predicate);
        T GetSingleNonTrackingBy(Expression<Func<T, bool>> predicate);
        Task<int> GetCount(Expression<Func<T, bool>> predicate);
        Task Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
        void Detach(T entity);
        void DetachAll(List<T> entities);
        void Save();
    }
}
