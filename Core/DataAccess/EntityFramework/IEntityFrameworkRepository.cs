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
    }
}
