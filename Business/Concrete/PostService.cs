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
            try
            {
                post.CreatedDateTime = DateTime.Now;
                _postDal.Add(post);

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
            try
            {
                var entity = _postDal.Get(x => x.Id == id, null);

                if (entity != null)
                    _postDal.Delete(entity);

                return true;
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.Message);
                throw;
            }
        }

        public Post GetById(int id)
        {
            try
            {
                return _postDal.Get(x => x.Id == id, null);
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.Message);
                throw;
            }
        }

        public bool Update(Post post)
        {
            using MainDbContext context = new MainDbContext();
            post.UpdatedDateTime = DateTime.Now;
            try
            {
                _postDal.Update(post);
                return true;
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.Message);
                throw;
            }

        }

        public List<Post> GetAll()
        {
            try
            {
                _postDal.GetAll(null, null);
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }


}
