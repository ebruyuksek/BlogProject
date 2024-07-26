using Business.Abstract;
using Core.Entities;
using DataAccess.Abstract;
using Microsoft.Extensions.Logging;

namespace Business.Concrete
{
    public class AdminUserService : IAdminUserService
    {
        private readonly IAdminUserDal _adminUserDal;
        private readonly ILogger _logger;
        public AdminUserService(IAdminUserDal adminUserDal, ILogger<AdminUserService> logger)
        {
            _adminUserDal = adminUserDal;
            _logger = logger;   
        }
        public AdminUser GetById(int id)
        {
            try
            {
                return _adminUserDal.Get(x => x.Id == id, null);
            }
            catch (Exception ex)
            {
                _logger.Log(LogLevel.Error, ex.Message);
                throw;
            }
        }

        public bool Update(AdminUser post)
        {
            throw new NotImplementedException();
        }
    }
}
