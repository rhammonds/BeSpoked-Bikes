using BBSData;
using BBSService.Api;

namespace BBSDataSeed
{
    internal class SalesDataSeed
    {
        public void SeedData()
        {
            ISaleApi _saleApi = new SaleApi();
            var sale = new Sale
            {
                SalesEmployeeId = 1,
                CustomerId = 1,
                ProductId = 1,
                SalesDate = DateTime.Now,  
            };
            var result = _saleApi.Add(sale).Result;
        }
    }
}
