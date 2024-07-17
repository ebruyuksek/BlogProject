namespace Core.Abstract
{
    public interface IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public DateTime? UpdatedDateTime { get; set; }
        public bool IsPassive { get; set; }
    }
}
