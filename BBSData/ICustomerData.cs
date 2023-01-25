 
namespace BBSData
{
    public interface ICustomerData
    {
        Task<IEnumerable<Customer>> GetCustomers();
        Task<int> Add(Customer customer);
    }
}
