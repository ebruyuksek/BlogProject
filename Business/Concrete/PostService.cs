using Business.Abstract;
using Core.Entities;
using DataAccess.Abstract;
using DataAccess.Context;
using Microsoft.Extensions.Logging;

namespace Business.Concrete
{
    public class PostService : IPostService
    {
        private readonly IPostDal _postDal;
        private readonly ILogger _logger;  

        public PostService(IPostDal postDal, ILogger<PostService> logger)
        {
            _postDal = postDal;
            _logger = logger;
        }

        public bool Add(Post post)
        {
            using MainDbContext db = new MainDbContext();
            try
            {
                post.CreatedDateTime = DateTime.Now;
                post.PostCategoryId = 1;
                db.Posts.Add(post);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.Message);
                throw;
            }
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Post GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void ServiceTest()
        {

        }

        public bool Update(Post post)
        {
            throw new NotImplementedException();
        }
    }


}
