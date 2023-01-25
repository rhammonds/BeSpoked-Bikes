using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBSData
{
    public class BBSDbContext: DbContext
    {
        public IDbSet<Customer> Customers { get; set; }
        public IDbSet<Discount> Discounts { get; set; }
        public IDbSet<Employee> Employees { get; set; }
        public IDbSet<Product> Products { get; set; }
        public IDbSet<Sale> Sales { get; set; }

         
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<BBSDbContext>(null);
            base.OnModelCreating(modelBuilder);
        }

    }

    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class Discount
    {
        [Key]
        public int DiscountId { get; set; }
        public int ProductId { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsDeleted { get; set; }

    }
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public int ManagerEmployeeId { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public int QtyOnHand { get; set; }
        public decimal CommissionPercentage { get; set; }
        public bool IsDeleted { get; set; }
    }
    public class Sale
    {
        [Key]
        public int SalesId { get; set; }
        public int ProductId { get; set; }
        public int SalesEmployeeId { get; set; }
        public int CustomerId { get; set; }
        public DateTime SalesDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
