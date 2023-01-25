using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSBWebApp.Models
{
    public class SaleDetail
    {       
        public string Product { get; set; }
        public string SalesPerson { get; set; }
        public string Customer { get; set; }
        public DateTime SalesDate { get; set; }
        public decimal Price { get; set; }
        public decimal SalesCommission { get; set; }
    }
}
