using BBSData;
using BBSData.Models;

namespace BBSService.Api
{
    public interface ISaleApi
    {
        Task<IEnumerable<SaleDetail>> Select(DateTime? from, DateTime? to);
        Task<bool> Add(Sale sale);
        Task<IEnumerable<SalesPersonCommisonDetail>> SelectQuarterlySalesCommission();
    }
}
