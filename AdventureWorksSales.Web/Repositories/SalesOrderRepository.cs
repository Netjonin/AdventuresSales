using AdventureWorksSales.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureWorksSales.Web.Repositories
{
    public class SalesOrderRepository : ISalesOrderRepository
    {
        private readonly AdventureWorksSalesContext _context;

        public SalesOrderRepository(AdventureWorksSalesContext context)
        {
            _context = context;
        }

        public IEnumerable<SalesOrder> GetSalesOrders()
        {
            return _context.SalesOrder;
        }
    }
}