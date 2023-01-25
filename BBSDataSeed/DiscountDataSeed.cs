using BBSData;
using BBSService.Api;

namespace BBSDataSeed
{
    internal class DiscountDataSeed
    {
        public void SeedData()
        {
            IDiscountApi _discountApi = new DiscountApi();
            var discount = new Discount
            {
                BeginDate = DateTime.Now,
                 EndDate = DateTime.Now,
                   ProductId = 0
            };
            var result = _discountApi.Add(discount).Result;
        }
    }
}
