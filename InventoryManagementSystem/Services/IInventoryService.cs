using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Services
{
    public interface IInventoryService
    {
        System.Threading.Tasks.Task<System.Collections.Generic.List<Product>> GetAllAsync();
        System.Threading.Tasks.Task<Product?> GetByIdAsync(System.Guid id);
        System.Threading.Tasks.Task AddAsync(Product product);
        System.Threading.Tasks.Task UpdateAsync(Product product);
        System.Threading.Tasks.Task DeleteAsync(System.Guid id);
    }
}
