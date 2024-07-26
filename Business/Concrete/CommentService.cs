using Business.Abstract;
using Core.Entities;
using DataAccess.Abstract;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CommentService : ICommentService
    {
        private readonly ILogger _logger;
        private readonly ICommentDal _commentDal;
        public CommentService(ICommentDal commentDal, ILogger<CommentService> logger)
        {
            _commentDal = commentDal;
            _logger = logger;
        }

        public void Add(Comment comment)
        {
            try
            {
                _commentDal.Add(comment);
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.Message);
                throw;
            }
        }

        public List<Comment> GetAll()
        {
            try
            {
                return _commentDal.GetAll(null, null);
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.Message);
                throw;
            }
        }

        public Comment GetComment(int id)
        {
            throw new NotImplementedException();
        }

        public bool IsCommentApproved(Comment comment)
        {
            throw new NotImplementedException();
        }
    }
}
