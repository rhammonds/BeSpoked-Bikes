
namespace BBSData
{
    public class CustomerData : ICustomerData
    {
        private BBSDbContext _dbContext;

        public CustomerData()
        {
            _dbContext = new BBSDbContext();

        }

        public async Task<int> Add(Customer customer)
        {
            _dbContext.Customers.Add(customer);
            return await _dbContext.SaveChangesAsync();
             
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await Task.FromResult(_dbContext.Customers.ToList());
        }
    }
}
