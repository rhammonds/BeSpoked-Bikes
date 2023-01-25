 

namespace BBSData
{
    public interface ISaleData
    {
        Task<IEnumerable<Sale>> GetSales(DateTime? from, DateTime? to);
        Task<int> Add(Sale sale);

    }
}
