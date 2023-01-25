using BBSData;
namespace BBSService.Api
{
    public interface ICustomerApi
    {
        Task<IEnumerable<Customer>> GetCustomers();
        Task<int> Add(Customer customer);
    }
}
