using Core.DataAccess.EntityFramework;
using Core.Entities;

namespace DataAccess.Abstract
{
    public interface IPostCategoryDal : IEntityFrameworkRepository<PostCategory>
    {
    }
}
