using Core.Concrete;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Core.DataAccess.EntityFramework
{
    public class EntityFrameworkRepository<TEntity, TContext> : IEntityFrameworkRepository<TEntity>
    where TEntity : Entity, new()
    where TContext : DbContext, new()
    {
        public TEntity? Get(Expression<Func<TEntity, bool>> filter, string[]? includes)
        {
            using var context = new TContext();

            if (includes == null)
                return context.Set<TEntity>().FirstOrDefault(filter);

            var queryable =
                includes.Aggregate(context.Set<TEntity>().AsQueryable(), (query, include)
                    => query.Include(include));

            return queryable.FirstOrDefault(filter!);
        }
    }
}
