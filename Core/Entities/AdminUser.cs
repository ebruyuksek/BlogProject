using Core.Concrete;

namespace Core.Entities
{
    public class AdminUser : Entity
    {
        public required string UserName { get; set; }
        public required string HashedPassword { get; set; }
    }
}
