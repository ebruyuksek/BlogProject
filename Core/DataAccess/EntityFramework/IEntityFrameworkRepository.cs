using Core.Concrete;
using System.Linq.Expressions;

namespace Core.DataAccess.EntityFramework
{
    public interface IEntityFrameworkRepository<T> where T : Entity, new()
    {
        T? Get(Expression<Func<T, bool>> filter, string[]? includes);
        List<T> GetAll(Expression<Func<T, bool>>? filter, string[]? includes);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
