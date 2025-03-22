using BaseEntity;

namespace Product.Domain
{
    public class Brand : BaseEntity<Guid>
    {
        public string Name { get; set; }
    }
}
