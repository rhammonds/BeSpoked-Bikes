 
using BBSDataSeed; 

new CustomerDataSeed().SeedData();
Console.WriteLine("Customer table seeding complete.");

new EmployeeDataSeed().SeedData();
Console.WriteLine("Employee table seeding complete.");

new ProductDataSeed().SeedData();
Console.WriteLine("Products table seeding complete.");

new DiscountDataSeed().SeedData();
Console.WriteLine("Discount table seeding complete.");

//new SalesDataSeed().SeedData();
//Console.WriteLine("Sales table seeding complete.");
//Console.ReadKey();
