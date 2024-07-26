using Business.Abstract;
using Core.Entities;
using DataAccess.Abstract;
using DataAccess.Context;
using Microsoft.Extensions.Logging;

namespace Business.Concrete
{
    public class PostCategoryService : IPostCategoryService
    {
        private readonly IPostCategoryDal _postCategoryDal;
        private readonly ILogger _logger;

        public PostCategoryService(IPostCategoryDal postCategoryDal, ILogger<PostService> logger)
        {
            _postCategoryDal = postCategoryDal;
            _logger = logger;
        }

        public bool Add(PostCategory post)
        {
            try
            {
                post.CreatedDateTime = DateTime.Now;
                _postCategoryDal.Add(post);

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
                var entity = _postCategoryDal.Get(x => x.Id == id, null);

                if (entity != null)
                    _postCategoryDal.Delete(entity);

                return true;
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.Message);
                throw;
            }
        }

        public PostCategory GetById(int id)
        {
            try
            {
                return _postCategoryDal.Get(x => x.Id == id, null);
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.Message);
                throw;
            }
        }

        public bool Update(PostCategory postCategory)
        {
            using MainDbContext context = new MainDbContext();
            try
            {
                _postCategoryDal.Update(postCategory);
                return true;
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.Message);
                throw;
            }
        }

        public List<PostCategory> GetAll()
        {
            try
            {
                return _postCategoryDal.GetAll(null, null);
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.Message);
                throw;
            }
        }
    }
}

