using Core.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Core.Concrete
{
    public class Entity : IEntity
    {
        [Key] public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime CreatedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public bool IsPassive { get; set; }
    }
}
