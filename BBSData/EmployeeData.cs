
namespace BBSData
{
    public class EmployeeData : IEmployeeData
    {
        private BBSDbContext _dbContext;
        public EmployeeData()
        {
            _dbContext = new BBSDbContext();
        }
        public async Task<int> Add(Employee employee)
        {
            _dbContext.Employees.Add(employee);
            return await _dbContext.SaveChangesAsync();
        }

        public async Task<Employee> Get(int employeeId)
        {
            return await Task.FromResult(_dbContext.Employees.Where(i => i.EmployeeId == employeeId && !i.IsDeleted).Single());
        } 

        public Task<IEnumerable<Employee>> GetSalesCommisionReport()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> Select()
        {
            return await Task.FromResult(_dbContext.Employees.ToList());
        }

        public async Task<bool> Update(Employee employee)
        {
            var entity = _dbContext.Employees.Where(i => i.EmployeeId == employee.EmployeeId && !i.IsDeleted).SingleOrDefault();
            if (entity != null)
            {
                entity.Address = employee.Address;
                entity.City = employee.City;
                entity.State = employee.State;
                entity.TerminationDate = employee.TerminationDate;
                entity.StartDate = employee.StartDate;
                entity.FirstName = employee.FirstName;
                entity.LastName = employee.LastName;
                entity.ManagerEmployeeId = employee.ManagerEmployeeId;
                entity.PhoneNumber = employee.PhoneNumber;
                entity.PostalCode = employee.PostalCode;

                await _dbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }


    }
}
