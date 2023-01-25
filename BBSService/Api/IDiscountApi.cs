using BBSData;

namespace BBSService.Api
{
    public interface IDiscountApi
    {
        Task<int> Add(Discount discount);
        Task<IEnumerable<Discount>> GetDiscounts();
    }
}
