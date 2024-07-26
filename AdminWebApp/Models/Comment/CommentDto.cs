namespace AdminWebApp.Models.Comment
{
    public class CommentDto
    {
        public int Id { get; set; }
        public string Text { get; set; } = null!;
        public bool IsPassive { get; set; } 
        public int PostId { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}
