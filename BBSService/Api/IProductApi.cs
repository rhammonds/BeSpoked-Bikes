using BBSData;

namespace BBSService.Api
{
    public interface IProductApi
    {
        Task<IEnumerable<Product>> Select();
        Task<Product> Get(int productId);
        Task<bool> Update(Product product);
        Task<int> Add(Product product);
    }
}
