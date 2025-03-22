namespace BaseEntity
{
    public abstract class BaseEntity<TKey> : IEntity<TKey>
    {
        public required TKey Id { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
