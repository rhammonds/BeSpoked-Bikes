using BBSData;
using BBSData.Models;

namespace BBSService.Api
{
    public class SaleApi : ISaleApi
    {
        ISaleData _saleData;
        IReportsData _reportsData;

        public SaleApi()
        {
            _saleData = new SaleData();
            _reportsData = new ReportsData();
        }
        public async Task<IEnumerable<SaleDetail>> Select(DateTime? from, DateTime? to)
        {
            return await _reportsData.GetSales(from, to);  
        } 

        public async Task<bool> Add(Sale sale)
        {
            await _saleData.Add(sale);
            return true;
        }

        public async Task<IEnumerable<SalesPersonCommisonDetail>> SelectQuarterlySalesCommission()
        {
            return await _reportsData.GetQuarterlySalesCommission();
        }
    }
}
