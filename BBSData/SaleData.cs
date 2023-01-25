
namespace BBSData
{
    public class SaleData : ISaleData
    {
        private BBSDbContext _dbContext;

        public SaleData()
        {
            _dbContext = new BBSDbContext();

        }
        public async Task<IEnumerable<Sale>> GetSales(DateTime? from, DateTime? to)
        {
            return await Task.FromResult(_dbContext.Sales.ToList());
            //todo filter
        }
        public async Task<int> Add(Sale sale)
        {
            _dbContext.Sales.Add(sale);
            return await _dbContext.SaveChangesAsync();
        }
    }
}
