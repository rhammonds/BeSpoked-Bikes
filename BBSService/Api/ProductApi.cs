using BBSData;

namespace BBSService.Api
{
    public class ProductApi : IProductApi
    {
        IProductData _productData;
       
        public ProductApi()
        {
            _productData = new ProductData();
        }
        public async Task<IEnumerable<Product>> Select()
        {
            return await _productData.Select();
        }

        public async Task<bool> Update(Product product)
        {
            return await _productData.Update(product);
        }

        public async Task<int> Add(Product product)
        {
            return await _productData.Add(product);
        }

        public async Task<Product> Get(int productId)
        {
            return await _productData.Get(productId);
        }
    }
}
