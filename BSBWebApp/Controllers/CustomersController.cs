using BSBWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BSBWebApp.Controllers
{
    public class CustomersController : Controller
    {
        public async Task<IActionResult> Select()
        {
            var  customers = new List<Customer>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:7100/Customer"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    if(apiResponse != null)
                    {
                        customers = JsonConvert.DeserializeObject<List<Customer>>(apiResponse);
                    }
                }
            }
            return View(customers);
        }
    }
}
