using BBSData;

namespace BBSService.Api
{
    public class EmployeeApi : IEmployeeApi
    {
        private IEmployeeData _employeeData;

        public EmployeeApi()
        {
            _employeeData = new EmployeeData();
        }
        public async Task<IEnumerable<Employee>> GetSalesCommisionReport()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> Select()
        {
            return await _employeeData.Select();
        }

        public async Task<bool> Update(Employee salesPerson)
        {
            return await _employeeData.Update(salesPerson);
        }

        public async Task<int> Add(Employee employee)
        {
             
            return await _employeeData.Add(employee);
             
        }

        public async Task<Employee> Get(int employeeId)
        {
            return await _employeeData.Get(employeeId);
        }
    }
}
