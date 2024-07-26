using Core.Entities;

namespace Business.Abstract
{
    public interface IPostService
    {
        Post GetById(int id);
        List<Post> GetAll();
        bool Add(Post post);
        bool Update(Post post);
        bool Delete(int id);
    }
}
