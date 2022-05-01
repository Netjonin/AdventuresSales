using AdventureWorksSales.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdventureWorksSales.Web.Repositories
{
    public class ProductCategoryRepository : IProductCategoryRepository
    {
        private readonly AdventureWorksSalesContext _context;

        public ProductCategoryRepository(AdventureWorksSalesContext context)
        {
            _context = context;
        }

        public IEnumerable<ProductCategory> GetProductCategories()
        {
            return _context.ProductCategory.ToList();
        }
    }
}