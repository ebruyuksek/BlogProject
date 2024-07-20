using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAdminUserBusinessService
    {
        AdminUser GetById(int id);
        bool Update(AdminUser post);
    }
}
