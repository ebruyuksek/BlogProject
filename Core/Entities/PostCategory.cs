using Core.Concrete;

namespace Core.Entities
{
    public class PostCategory : Entity
    {
        public required string Name { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
