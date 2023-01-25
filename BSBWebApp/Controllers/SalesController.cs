using BSBWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace BSBWebApp.Controllers
{
    public class SalesController : Controller
    {
        public async Task<IActionResult> Select()
        {
            var sales = new List<SaleDetail>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"https://localhost:7100/Sale/Select?from={DateTime.Now.AddYears(-1)},&to={DateTime.Now.AddYears(1)}"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    if (apiResponse != null)
                    {
                        sales = JsonConvert.DeserializeObject<List<SaleDetail>>(apiResponse);
                    }
                }
            }
            return View(sales);
        }

        public async Task<IActionResult> SelectQuarterlySalesCommission()
        {
            var sales = new List<SalesPersonCommisonDetail>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:7100/Sale/GetQuarterlySalesCommission"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    if (apiResponse != null)
                    {
                        sales = JsonConvert.DeserializeObject<List<SalesPersonCommisonDetail>>(apiResponse);
                    }
                }
            }
            return View(sales);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        public async Task<IActionResult> SaveNew(Sale sale)
        {
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(sale), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://localhost:7100/Sale/Add", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }

            return RedirectToAction("Select", "Sales");

        }

    }
}
