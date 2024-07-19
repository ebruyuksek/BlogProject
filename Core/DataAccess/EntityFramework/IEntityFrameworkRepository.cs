using Core.Abstract;
using Core.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public interface IEntityFrameworkRepository<T> where T : Entity, new()
    {
        T? Get(Expression<Func<T, bool>> filter, string[]? includes);
        List<T> GetAll(Expression<Func<T, bool>> filter, string[]? includes);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
