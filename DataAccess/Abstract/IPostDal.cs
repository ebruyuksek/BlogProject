using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IPostDal : IEntityFrameworkRepository<Post>;
   
}
