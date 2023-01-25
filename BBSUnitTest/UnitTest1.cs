
using BBSData;
using BBSService.Api;
using Moq;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;
namespace BBSUnitTest
{

    public class Tests
    {
        private Mock<ICustomerData> _customerData;
        private ICustomerApi _customerApi;

        [Fact]
        public async void GetCustomer_NotNull()
        {
            //Arrange
            _customerData = new Mock<ICustomerData>();
            _customerData.Setup(r => r.GetCustomers()).Returns(Task.FromResult(GetCustomer()));

            //Act
            _customerApi = new CustomerApi(_customerData.Object);
            var customers = await _customerApi.GetCustomers();
 
            //Assert            
            Assert.NotNull(customers);
             
        }
        private IEnumerable<Customer> GetCustomer()
        {
            return new List<Customer> { new Customer { CustomerId =1, Address="test"}};
        }
    }
}