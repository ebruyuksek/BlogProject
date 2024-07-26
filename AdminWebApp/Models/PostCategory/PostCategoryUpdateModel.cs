namespace AdminWebApp.Models.PostCategory
{
    public class PostCategoryUpdateModel 
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsPassive { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
    }
}
