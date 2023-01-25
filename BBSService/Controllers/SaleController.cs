using BBSData;
using BBSData.Models;
using Microsoft.AspNetCore.Mvc;

namespace BBSService.Api
{
    [ApiController]
    [Route("[controller]")]
    public class SaleController : ControllerBase 
    {
        private ISaleApi _saleApi;

        public SaleController()
        {
            _saleApi = new SaleApi( );
        }

        [Route("Select")]
        [HttpGet]
        public async Task<IEnumerable<SaleDetail>> Select(DateTime? from, DateTime? to)
        {
            return  await _saleApi.Select(from, to);
        }

        [Route("GetQuarterlySalesCommission")]
        [HttpGet]
        public async Task<IEnumerable<SalesPersonCommisonDetail>> GetQuarterlySalesCommission()
        {
            return await _saleApi.SelectQuarterlySalesCommission();
        }

        [Route("Add")]
        [HttpPost]
        public async Task<bool> Add([FromBody] Sale sale)
        {
            return await _saleApi.Add(sale);
        }
    }
}
