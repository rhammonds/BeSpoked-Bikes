

namespace BBSData
{
    public interface IProductData
    {
        Task<IEnumerable<Product>> Select();
        Task<Product> Get(int productId);
        Task<bool> Update(Product product);
        Task<int> Add(Product product);

    }
}
