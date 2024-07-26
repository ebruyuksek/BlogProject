using Core.Concrete;

namespace AdminWebApp.Models.PostCategory
{
    public class PostCategoryListViewModel : Entity
    {
        public List<PostCategoryDto> PostCategories { get; set; } = new List<PostCategoryDto>();
        public bool IsActionHasOccured { get; set; } = false;
        public string? ActionMessage { get; set; }
    }

    public class PostCategoryDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }

    }
}
