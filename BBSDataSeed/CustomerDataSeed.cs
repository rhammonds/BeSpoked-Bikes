using BBSData;
using BBSService.Api;

namespace BBSDataSeed
{
    internal class CustomerDataSeed
    {
        public IEnumerable<Customer> SeedData()
        {
            IEnumerable<Customer> customers = new List<Customer>();
            ICustomerApi _customerApi = new CustomerApi();
            var customer = new Customer
            {
                FirstName = "George",
                LastName = "Washington",
                Address = "123 Main Street",
                City = "Mt Vernon",
                State = "VA",
                PostalCode = "11111",
                PhoneNumber = "1119999999",
                StartDate = DateTime.Parse("1/10/2023"),
            };
            var result = _customerApi.Add(customer).Result;

            customer = new Customer
            {
                FirstName = "John",
                LastName = "Adams",
                Address = "123 Main Street",
                City = "Boston",
                State = "MA",
                PostalCode = "11112",
                PhoneNumber = "2229999999",
                StartDate = DateTime.Parse("1/11/2023"),
            };
            result = _customerApi.Add(customer).Result;

            customer = new Customer
            {
                FirstName = "Thomas",
                LastName = "Jefferson",
                Address = "123 Main Street",
                City = "Charlottesville",
                State = "VA",
                PostalCode = "11113",
                PhoneNumber = "3339999999",
                StartDate = DateTime.Parse("1/12/2023"),
            };
            result = _customerApi.Add(customer).Result;
            return customers;
        }
    }
}
