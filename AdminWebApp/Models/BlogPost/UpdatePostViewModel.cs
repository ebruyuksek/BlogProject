namespace AdminWebApp.Models.BlogPost
{
    public class UpdatePostViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string Text { get; set; } = null!;

        //img eklenbilir.
    }
}
