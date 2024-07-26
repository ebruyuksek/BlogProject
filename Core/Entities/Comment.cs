using Core.Concrete;
using System.ComponentModel.DataAnnotations;

namespace Core.Entities
{
    public class Comment : Entity
    {
        public int PostId { get; set; }
        public string Text { get; set; } = null!;

        public new bool IsPassive { get; set; } = true;

        public virtual Post Post { get; set; }

    }
}
