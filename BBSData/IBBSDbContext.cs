using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBSData
{
    public interface IBBSDbContext
    {
        public IDbSet<Customer> Customers { get; set; }
        public IDbSet<Discount> Discounts { get; set; }
        public IDbSet<Employee> Employees { get; set; }         
        public IDbSet<Product> Products { get; set; }
        public IDbSet<Sale> Sales { get; set; }
         
    }
}
