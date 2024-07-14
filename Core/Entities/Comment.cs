using Core.Concrete;

namespace Core.Entities
{
    public class Comment : Entity
    {
        public Guid PostId { get; set; }
        public string Text { get; set; } = null!;

        public virtual Post Post { get; set; }

    }
}
