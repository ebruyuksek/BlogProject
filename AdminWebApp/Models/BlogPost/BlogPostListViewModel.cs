namespace AdminWebApp.Models.BlogPost
{
    public class BlogPostListViewModel 
    {
        public List<BlogPostDto> BlogPosts { get; set; } = new List<BlogPostDto>();
    }

    public class BlogPostDto
    {
        public required string Title { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}
