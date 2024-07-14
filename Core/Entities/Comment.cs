using Core.Concrete;

namespace Core.Entities
{
    public class Comment : Entity
    {
        public Guid PostId { get; set; }
        public required string Text { get; set; }

        public virtual Post Post { get; set; }

    }
}
