using BBSData.Models;

namespace BBSData
{
    public  interface IReportsData
    {
        Task<IEnumerable<SaleDetail>> GetSales(DateTime? from, DateTime? to);
        Task<IEnumerable<SalesPersonCommisonDetail>> GetQuarterlySalesCommission();
    }
}
