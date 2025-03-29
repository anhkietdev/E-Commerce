using Product.Domain.Abstractions;

namespace Product.Domain.Models
{
    public class Product : Entity<Guid>
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int StockQuantity { get; private set; }
        public Guid CategoryId { get; private set; }

        // Constructor for EF Core
        protected Product() { }

        public Product(string name, string description, decimal price, int stockQuantity, Guid categoryId, string createdBy)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            Price = price;
            StockQuantity = stockQuantity;
            CategoryId = categoryId;
            CreatedAt = DateTime.UtcNow;
            CreatedBy = createdBy;
        }

        public void Update(string name, string description, decimal price, int stockQuantity, string modifiedBy)
        {
            Name = name;
            Description = description;
            Price = price;
            StockQuantity = stockQuantity;
            LastModified = DateTime.UtcNow;
            LastModifiedBy = modifiedBy;
        }

        public void DecreaseStock(int quantity)
        {
            if (quantity <= 0)
                throw new ArgumentException("Quantity must be greater than zero.");
            if (StockQuantity < quantity)
                throw new InvalidOperationException("Not enough stock available.");

            StockQuantity -= quantity;
            LastModified = DateTime.UtcNow;
        }

        public void IncreaseStock(int quantity)
        {
            if (quantity <= 0)
                throw new ArgumentException("Quantity must be greater than zero.");

            StockQuantity += quantity;
            LastModified = DateTime.UtcNow;
        }
    }

}
