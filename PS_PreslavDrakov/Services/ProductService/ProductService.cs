using PS_PreslavDrakov.Model;
using SQLite;

namespace PS_PreslavDrakov.Services.ProductService
{
    public class ProductService : IProductRepository
    {
        public SQLiteAsyncConnection _database;
        public ProductService(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Product>().Wait();
        }
        public async Task<bool> AddUpdateProductAsync(Product product)
        {
            if (product.ProdId > 0)
            {
                await _database.UpdateAsync(product);
            }
            else
            {
                await _database.InsertAsync(product);
            }
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteProductAsync(int prodId)
        {
            await _database.DeleteAsync<Product>(prodId);
            return await Task.FromResult(true);
        }

        public async Task<Product> GetProductAsync(int prodId)
        {
            return await _database.Table<Product>().Where(p => p.ProdId == prodId).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await Task.FromResult(await _database.Table<Product>().ToListAsync());
        }
    }
}
