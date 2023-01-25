using BBSData;
using Microsoft.AspNetCore.Mvc;

namespace BBSService.Api
{
    [ApiController]
    [Route("[controller]")]
    public class DiscountController : ControllerBase 
    {
        private IDiscountApi _discountApi;

        public DiscountController()
        {
            _discountApi = new DiscountApi( );
        }

        [HttpGet(Name = "GetDiscounts")]
        public async Task<IEnumerable<Discount>> GetDiscounts()
        {
            return await _discountApi.GetDiscounts();
        }
    }
}
