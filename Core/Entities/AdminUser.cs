using Core.Concrete;

namespace Core.Entities
{
    public class AdminUser : Entity
    {
        public string UserName { get; set; } = null!;
        public string HashedPassword { get; set; } = null!;
    }
}
