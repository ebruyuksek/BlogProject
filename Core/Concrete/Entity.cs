using Core.Abstract;
using System.ComponentModel.DataAnnotations;

namespace Core.Concrete
{
    public class Entity : IEntity
    {
        [Key] public int Id { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public bool IsPassive { get; set; }
    }
}
