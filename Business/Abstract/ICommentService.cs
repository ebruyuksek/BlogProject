using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICommentService
    {
        Comment GetComment(int id);
        List<Comment> GetAll();
        bool IsCommentApproved(Comment comment);
        void Add(Comment comment);
    }
}
