﻿using Core.Concrete;

namespace Core.Entities
{
    public class Post : Entity
    {
        public string Title { get; set; } = null!;
        public string Text { get; set; } = null!;
        public string? ImageUrl { get; set; }
        public Guid PostCategoryId { get; set; }

        public ICollection<Comment> Comments { get; set; }
        public required virtual PostCategory PostCategory { get; set; }

    }
}
