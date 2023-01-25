

namespace BBSData
{
    public class DiscountData : IDiscountData
    {
        private BBSDbContext _dbContext;

        public DiscountData()
        {
            _dbContext = new BBSDbContext();

        }
        public async Task<int> Add(Discount discount)
        {
            _dbContext.Discounts.Add(discount);
            return await _dbContext.SaveChangesAsync();

        }

        public async Task<IEnumerable<Discount>> GetDiscounts()
        {
            return await Task.FromResult(_dbContext.Discounts.ToList());
        }
    }
}
