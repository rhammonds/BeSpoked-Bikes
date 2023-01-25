using BBSData;
using Microsoft.AspNetCore.Mvc;

namespace BBSService.Api
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase 
    {
        private IProductApi _productApi;

        public ProductController()
        {
            _productApi = new ProductApi( );
        }

        [Route("Select")]
        [HttpGet]
        public async Task<IEnumerable<Product>> Select()
        {
            return await _productApi.Select();
        }

        [Route("Get/{productId}")]
        [HttpGet]
        public async Task<Product> Get(int productId)
        {
            return await _productApi.Get(productId);
        }

        [Route("Update")]
        [HttpPost]
        public async Task<bool> Update([FromBody]Product product)
        {
            return await _productApi.Update(product);
        }
    }
}
