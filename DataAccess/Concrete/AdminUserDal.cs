using Core.DataAccess.EntityFramework;
using Core.Entities;
using DataAccess.Abstract;
using DataAccess.Context;

namespace DataAccess.Concrete
{
    public class AdminUserDal : EntityFrameworkRepository<AdminUser, MainDbContext>, IAdminUserDal
    {
    }
}
