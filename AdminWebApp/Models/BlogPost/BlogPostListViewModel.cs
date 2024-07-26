namespace AdminWebApp.Models.BlogPost
{
    public class BlogPostListViewModel 
    {
        public List<BlogPostDto> BlogPosts { get; set; } = new List<BlogPostDto>();
        public bool IsActionHasOccured { get; set; } = false;
        public string? ActionMessage { get; set; }
    }

    public class BlogPostDto
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
}
