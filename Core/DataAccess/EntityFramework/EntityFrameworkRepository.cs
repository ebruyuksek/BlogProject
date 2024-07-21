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

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>>? filter, string[]? includes)
        {
            using var context = new TContext();

            if (includes == null)
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();

            return filter == null
                ? includes.Aggregate(context.Set<TEntity>().AsQueryable(), (query, include)
                    => query.Include(include)).ToList()
                : includes.Aggregate(context.Set<TEntity>().AsQueryable(), (query, include)
                => query.Include(include).Where(filter)).ToList();
        }

        public void Add(TEntity entity)
        {
            using var context = new TContext();

            var addedEntity = context.Entry(entity);
            addedEntity.State = EntityState.Added;

            context.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            using var context = new TContext();
            entity.UpdatedDateTime = DateTime.Now;

            var updatedEntity = context.Entry(entity);
            updatedEntity.State = EntityState.Modified;

            context.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            using var context = new TContext();
            var deletedEntity = context.Entry(entity);
            deletedEntity.State = EntityState.Deleted;
            context.SaveChanges();
        }



    }
}
