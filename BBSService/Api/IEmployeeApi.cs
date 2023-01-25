using BBSData;

namespace BBSService.Api
{
    public interface IEmployeeApi
    {
        Task<IEnumerable<Employee>> Select();
        Task<Employee> Get(int employeeId);
        Task<bool> Update(Employee salesPerson);
        Task<int> Add(Employee employee);
        Task<IEnumerable<Employee>> GetSalesCommisionReport();
    }
}
