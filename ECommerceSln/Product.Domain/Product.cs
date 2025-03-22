using BaseEntity;

namespace Product.Domain
{
    public class Product : BaseEntity<Guid>
    {
        public required string ProductName { get; set; }
        public decimal PricePerUnit { get; set; }
        public required Brand BrandName { get; set; }
    }
}
