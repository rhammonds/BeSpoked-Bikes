using BBSData;
using BBSService.Api;

namespace BBSDataSeed
{
    internal class ProductDataSeed
    {
        public void SeedData()
        {
            IProductApi productApi = new ProductApi();

            var product = new Product
            {
                Name = "Kent Men's SeaChange 26",
                CommissionPercentage = 1,
                IsDeleted = false,
                Manufacturer = "Kent",
                QtyOnHand = 15,
                PurchasePrice = 40,
                SalePrice = 100
            };
            var result = productApi.Add(product).Result;

            product = new Product
            {
                Name = "Mongoose Dolomite Mens Fat Tire Mountain Bike",
                CommissionPercentage = 1,
                IsDeleted = false,
                Manufacturer = "Kent",
                QtyOnHand = 5,
                PurchasePrice = 300,
                SalePrice = 400
            };
            result = productApi.Add(product).Result;

            product = new Product
            {
                Name = "Schwinn Sidewinder Mountain Bike",
                CommissionPercentage = 1,
                IsDeleted = false,
                Manufacturer = "Kent",
                QtyOnHand = 20,
                PurchasePrice = 80,
                SalePrice = 150
            };
            result = productApi.Add(product).Result;
        }
    }
}
