using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
