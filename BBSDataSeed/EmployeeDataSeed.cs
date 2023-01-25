using BBSData;
using BBSService.Api; 

namespace BBSDataSeed
{
    internal class EmployeeDataSeed
    {
        public void SeedData()
        {
            IEmployeeApi salesPersonApi = new EmployeeApi();

            var employee = new Employee
            {
                EmployeeId = 1,
                FirstName = "R2",
                LastName = "D2",
                Address = "123 Main Street",
                City = "City1",
                PostalCode = "91111",
                State = "Alderaan",
                PhoneNumber = "2112223333",
                StartDate = DateTime.Parse("1/10/2023"),                
                TerminationDate = null,
                ManagerEmployeeId = 1,
                IsDeleted = false,
            };
            var managerId = salesPersonApi.Add(employee).Result;

            employee = new Employee
            {
                EmployeeId = 2,
                FirstName = "Luke",
                LastName = "Sywalker",
                Address = "123 Main Street",
                City = "City2",
                PostalCode = "91111",
                State = "Tatooine",
                PhoneNumber = "3112223333",
                StartDate = DateTime.Parse("1/10/2023"),
                ManagerEmployeeId = 1,
                TerminationDate = null,
                IsDeleted = false,
            };
            var employeeId = salesPersonApi.Add(employee).Result;

            employee = new Employee
            {
                EmployeeId = 3,
                FirstName = "Darth",
                LastName = "Vader",
                Address = "123 Main Street",
                City = "City3",
                PostalCode = "91111",
                State = "Naboo",
                PhoneNumber = "4112223333",
                StartDate = DateTime.Parse("1/10/2023"),
                ManagerEmployeeId = 1,
                TerminationDate = null,
                IsDeleted = false,
            };
            employeeId = salesPersonApi.Add(employee).Result;
        }
    }
}
