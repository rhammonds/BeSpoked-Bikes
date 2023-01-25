 
namespace BBSData
{
    public interface IEmployeeData
    {
        Task<IEnumerable<Employee>> Select();
        Task<Employee> Get(int employeeId);
        Task<bool> Update(Employee employee);       
        Task<int> Add(Employee employee);
        Task<IEnumerable<Employee>> GetSalesCommisionReport();
    }
}
