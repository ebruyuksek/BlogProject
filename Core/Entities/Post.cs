using Core.Concrete;

namespace Core.Entities
{
    public class Post : Entity
    {
        public string Title { get; set; } = null!;
        public string Text { get; set; } = null!;
        public string? ImageUrl { get; set; }
        public int PostCategoryId { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public virtual PostCategory PostCategory { get; set; }

    }
}
