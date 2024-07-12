using Core.Concrete;

namespace Core.Entities
{
    public class PostCategory : Entity
    {
        public required string Name { get; set; }

        public List<Post> Posts { get; set; } = new List<Post>();
    }
}
