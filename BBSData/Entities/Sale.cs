using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBSData
{
    public class Sale
    {
        public long SalesId { get; set; }
        public int ProductId { get; set; }
        public int SalesEmployeeId { get; set; }
        public int CustomerId { get; set; }
        public DateTime SalesDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
