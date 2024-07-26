using Core.Entities;

namespace Business.Abstract
{
    public interface IPostCategoryService
    {
        PostCategory GetById(int id);
        List<PostCategory> GetAll();
        bool Add(PostCategory post);
        bool Update(PostCategory post);
    }
}
