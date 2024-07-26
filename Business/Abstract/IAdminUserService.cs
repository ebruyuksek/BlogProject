using Core.Entities;

namespace Business.Abstract
{
    public interface IAdminUserService
    {
        AdminUser GetById(int id);
        bool Update(AdminUser post);
    }
}
