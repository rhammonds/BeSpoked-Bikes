using BSBWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace BSBWebApp.Controllers
{
    public class ProductsController : Controller
    {
        public async Task<IActionResult> Select()
        {
            var products = new List<Product>();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://localhost:7100/Product/Select"))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    if (apiResponse != null)
                    {
                        products = JsonConvert.DeserializeObject<List<Product>>(apiResponse);
                    }
                }
            }
            return View(products);
        }

        public async Task<IActionResult> Edit(int productId)
        {
            var product = new Product();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync($"https://localhost:7100/Product/Get/{productId}"))  
                    {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    if (apiResponse != null)
                    {
                        product = JsonConvert.DeserializeObject<Product>(apiResponse);
                    }
                }
            }
            return View(product);
        }
        
        public async Task<IActionResult> Save(Product product)
        {
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(product), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("https://localhost:7100/Product/Update", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
          
            return RedirectToAction("Select", "Products");
        }
    }
}
