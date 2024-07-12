using Core.Abstract;

namespace Core.Entities
{
    public class AdminUser : IEntity
    {
        public Guid Id { get; set; }
        public required string UserName { get; set; }
        public DateTime CreatedDateTime { get; set ; }
        public DateTime UpdatedDateTime { get; set; }
        public bool IsPassive { get; set; }
        public required string HashedPassword { get; set; }
    }
}
