namespace AdminWebApp.Models.Comment
{
    public class CommentListViewModel
    {
        public List<CommentDto> CommentList { get; set; } = new List<CommentDto>();
        public bool IsActionHasOccured { get; set; } = false;
        public string? ActionMessage { get; set; }

    }
}
