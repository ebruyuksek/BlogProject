using Core.Concrete;

namespace Core.Entities
{
    public class Comment : Entity
    {
        public int PostId { get; set; }
        public required string Text { get; set; }


        public required virtual Post Post { get; set; }
    }
}
