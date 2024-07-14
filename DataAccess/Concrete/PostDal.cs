using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Abstract;
using DataAccess.Context;

namespace DataAccess.Concrete
{
    public class PostDal : EntityFrameworkRepository<Post, MainDbContext>, IPostDal;
}
