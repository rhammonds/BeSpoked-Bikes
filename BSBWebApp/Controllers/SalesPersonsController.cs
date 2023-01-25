using BSBWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace BSBWebApp.Controllers
{
    public class SalesPersonsController : Controller
    {
        public async Task<IActionResult> Select()
        {
            var employees = new List<Employee>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:7100/SalesPerson/Select"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    if (apiResponse != null)
                    {
                        employees = JsonConvert.DeserializeObject<List<Employee>>(apiResponse);
                    }
                }
            }
            return View(employees);
        }

        public async Task<IActionResult> Edit(int employeeId)
        {
            var employee = new Employee();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"https://localhost:7100/SalesPerson/Get/{employeeId}"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    if (apiResponse != null)
                    {
                        employee = JsonConvert.DeserializeObject<Employee>(apiResponse);
                    }
                }
            }
            return View(employee);
        }

        public async Task<IActionResult> Save(Employee employee)
        {
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(employee), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://localhost:7100/Employee/Update", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }

            return RedirectToAction("Select", "SalesPersons");
        }
    }
}
