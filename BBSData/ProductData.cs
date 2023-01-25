using System.Linq;
using System.Collections.Generic;
namespace BBSData
{
    public class ProductData : IProductData
    {
        private BBSDbContext _dbContext;

        public ProductData()
        {
            _dbContext = new BBSDbContext();

        }
        public async Task<int> Add(Product product)
        {
            _dbContext.Products.Add(product);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<Product> Get(int productId)
        {
            return await Task.FromResult(_dbContext.Products.Where(i => i.ProductId == productId && !i.IsDeleted).Single());
        }

        public async Task<IEnumerable<Product>> Select()
        {
            return await Task.FromResult(_dbContext.Products.Where(i => !i.IsDeleted).ToList());
        }

        public async Task<bool> Update(Product product)
        {
            var entity = _dbContext.Products.Where(i => i.ProductId == product.ProductId && !product.IsDeleted).Single();

            entity.Manufacturer = product.Manufacturer;
            entity.SalePrice = product.SalePrice;
            entity.PurchasePrice = product.PurchasePrice;
            entity.CommissionPercentage = product.CommissionPercentage;
            entity.QtyOnHand = product.QtyOnHand;
            entity.Name = product.Name;
            await _dbContext.SaveChangesAsync();

            return true;
        }
    }
}
