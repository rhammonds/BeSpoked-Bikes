using BBSData;

namespace BBSService.Api
{
    public class CustomerApi : ICustomerApi
    {
        private ICustomerData _customerData;
        public CustomerApi(ICustomerData customerData)
        {
            _customerData = customerData;
        }
        public CustomerApi()
        {
            _customerData = new CustomerData();
        }
        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _customerData.GetCustomers();
        }

        public async Task<int> Add(Customer customer)
        {
            return await _customerData.Add(customer);
        }
    }
}
