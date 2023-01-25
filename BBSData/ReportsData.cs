using BBSData.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBSData
{
    public class ReportsData : IReportsData
    {
        private BBSDbContext _dbContext;

        public ReportsData()
        {
            _dbContext = new BBSDbContext();

        }

        public async Task<IEnumerable<SaleDetail>> GetSales(DateTime? from, DateTime? to)
        {
            var sql = @"select 
                    e.FirstName + ' ' + e.LastName SalesPerson, 
                    c.FirstName + ' ' + c.LastName Customer, 
                    p.Name as Product,
                    SalesDate, 
                    p.SalePrice Price, 
                    p.SalePrice * p.CommissionPercentage /100 SalesCommission 
                    from sales s
                    join Customers c on c.CustomerId = s.CustomerId
                    join Employees e on e.EmployeeId = s.SalesEmployeeId
                    join Products p on p.ProductId = s.ProductId";

            if(from!=null)
            {
                sql += " where s.SalesDate between @from and @to";
            }

            var data = _dbContext.Database.SqlQuery<SaleDetail>(sql,
                new SqlParameter("@from", from), new SqlParameter("@to", to));
            return data.ToList();
        }

        public async Task<IEnumerable<SalesPersonCommisonDetail>> GetQuarterlySalesCommission()
        {
            var data = _dbContext.Database.SqlQuery<SalesPersonCommisonDetail>(
                @"select 
                    e.FirstName + ' ' + e.LastName SalesPerson, 
					case 
						when Month(s.SalesDate) between 1 and 3 then 1
						when Month(s.SalesDate) between 4 and 6 then 2
						when Month(s.SalesDate) between 7 and 9 then 3
						when Month(s.SalesDate) between 10 and 12 then 4
					end 'Quarter',
                    sum(p.SalePrice * p.CommissionPercentage /100) SalesCommission 
                    from sales s                    
                    join Employees e on e.EmployeeId = s.SalesEmployeeId
					join Products p on p.ProductId = s.ProductId					
					group by e.FirstName + ' ' + e.LastName,
										case 
						when Month(s.SalesDate) between 1 and 3 then 1
						when Month(s.SalesDate) between 4 and 6 then 2
						when Month(s.SalesDate) between 7 and 9 then 3
						when Month(s.SalesDate) between 10 and 12 then 4
					end  ");
            return data.ToList();
        }
    }
}
