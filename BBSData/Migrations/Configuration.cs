namespace BBSData.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BBSData.BBSDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BBSData.BBSDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
            context.Customers.AddOrUpdate(x => x.CustomerId,
                new Customer
                {
                    FirstName = "Martha",
                    LastName = "Washington",
                    Address = "123 Main Street",
                    City = "Mt Vernon",
                    State = "VA",
                    PostalCode = "11111",
                    PhoneNumber = "1119999999",
                    StartDate = DateTime.Parse("1/10/2023"),
                });
        }
    }
}
