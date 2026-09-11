using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Services
{
    public interface IInventoryService
    {
    Task<System.Collections.Generic.List<Product>> GetAllAsync();
      Task<Product?> GetByIdAsync(System.Guid id);
      Task AddAsync(Product product);
      Task UpdateAsync(Product product);
      Task DeleteAsync(System.Guid id);
    }
}
