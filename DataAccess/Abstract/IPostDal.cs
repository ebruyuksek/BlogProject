﻿using Core.DataAccess.EntityFramework;
using Core.Entities;

namespace DataAccess.Abstract
{
    public interface IPostDal : IEntityFrameworkRepository<Post>;
   
}
