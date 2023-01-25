using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBSData.Models
{
    public class SalesPersonCommisonDetail
    {
        public string SalesPerson { get; set; }
        public int Quarter { get; set; }
        public decimal SalesCommission { get; set; }
    }
}
