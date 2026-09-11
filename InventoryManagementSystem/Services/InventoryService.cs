using InventoryManagementSystem.Models;
using System.Collections.Concurrent;

namespace InventoryManagementSystem.Services
{
    public class InventoryService : IInventoryService
    {
        private readonly ConcurrentDictionary<System.Guid, Product> _store = new();

        public InventoryService()
        {
            // seed some sample data
            var p1 = new Product { Name = "Sample Item A", Description = "Sample item A", Quantity = 10, Price = 9.99M };
            var p2 = new Product { Name = "Sample Item B", Description = "Sample item B", Quantity = 5, Price = 19.99M };
            _store[p1.Id] = p1;
            _store[p2.Id] = p2;
        }

        public System.Threading.Tasks.Task AddAsync(Product product)
        {
            if (product.Id == System.Guid.Empty) product.Id = System.Guid.NewGuid();
            _store[product.Id] = product;
            return System.Threading.Tasks.Task.CompletedTask;
        }

        public System.Threading.Tasks.Task DeleteAsync(System.Guid id)
        {
            _store.TryRemove(id, out _);
            return System.Threading.Tasks.Task.CompletedTask;
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<Product>> GetAllAsync()
        {
            var list = _store.Values.OrderBy(p => p.Name).ToList();
            return System.Threading.Tasks.Task.FromResult(list);
        }

        public System.Threading.Tasks.Task<Product?> GetByIdAsync(System.Guid id)
        {
            _store.TryGetValue(id, out var p);
            return System.Threading.Tasks.Task.FromResult(p);
        }

        public System.Threading.Tasks.Task UpdateAsync(Product product)
        {
            _store[product.Id] = product;
            return System.Threading.Tasks.Task.CompletedTask;
        }
    }
}
