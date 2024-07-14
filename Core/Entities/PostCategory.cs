using Core.Concrete;

namespace Core.Entities
{
    public class PostCategory : Entity
    {
        public string Name { get; set; } = null!;

        public ICollection<Post> Posts { get; set; }
    }
}
