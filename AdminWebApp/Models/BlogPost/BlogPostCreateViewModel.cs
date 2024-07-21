namespace AdminWebApp.Models.BlogPost
{
    public class BlogPostCreateViewModel
    {
        public int PostCategoryId { get; set; }
        public string Title { get; set; } = null!;
        public string Text { get; set; } = null!;
    }
}
