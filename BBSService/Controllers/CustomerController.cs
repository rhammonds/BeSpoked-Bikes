using BBSData;
using Microsoft.AspNetCore.Mvc;

namespace BBSService.Api
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase 
    {
        private ICustomerApi _customerApi;

        public CustomerController()
        {
            _customerApi = new CustomerApi( );
        }

        [HttpGet(Name = "GetCustomers")]
        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await _customerApi.GetCustomers();
        }
    }
}
