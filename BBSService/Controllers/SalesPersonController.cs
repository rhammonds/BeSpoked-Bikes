using BBSData;
using Microsoft.AspNetCore.Mvc;

namespace BBSService.Api
{
    [ApiController]
    [Route("[controller]")]
    public class SalesPersonController : ControllerBase 
    {
        private IEmployeeApi _employeeApi;

        public SalesPersonController()
        {
            _employeeApi = new EmployeeApi( );
        }

        [Route("Select")]
        [HttpGet]
        public async Task<IEnumerable<Employee>> Select()
        {
            return await _employeeApi.Select();
        }

        [Route("Get/{employeeId}")]
        [HttpGet]
        public async Task<Employee> Get(int employeeId)
        {
            return await _employeeApi.Get(employeeId);
        }

        [Route("Update")]
        [HttpPost]
        public async Task<bool> Update([FromBody] Employee employee)
        {
            return await _employeeApi.Update(employee);
        }
    }
}
