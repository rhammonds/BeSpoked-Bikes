using BBSData; 

namespace BBSService.Api
{
    public class DiscountApi : IDiscountApi
    {
        private IDiscountData _discountData;
        public DiscountApi()
        {
            _discountData = new DiscountData();
        }
        public async Task<int> Add(Discount discount)
        {
            return await _discountData.Add(discount);
        }

        public async Task<IEnumerable<Discount>> GetDiscounts()
        {
            return await _discountData.GetDiscounts();
        }
 
    }
}
