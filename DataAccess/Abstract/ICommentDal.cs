using Core.DataAccess.EntityFramework;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICommentDal : IEntityFrameworkRepository<Comment>
    {
    }
}
