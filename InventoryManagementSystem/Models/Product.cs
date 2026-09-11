namespace InventoryManagementSystem.Models
{
    public class Product
    {
        public System.Guid Id { get; set; } = System.Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
    }
}
