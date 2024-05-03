using PS_PreslavDrakov.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS_PreslavDrakov.Services.ProductService
{
    public interface IProductRepository
    {
        Task<bool> AddUpdateProductAsync(Product product);
        Task<bool> DeleteProductAsync(int prodId);
        Task<Product> GetProductAsync(int prodId);
        Task<IEnumerable<Product>> GetProductsAsync();
    }
}
