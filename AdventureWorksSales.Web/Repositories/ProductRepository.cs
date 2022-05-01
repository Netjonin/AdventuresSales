using AdventureWorksSales.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureWorksSales.Web.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly AdventureWorksSalesContext _context;

        public ProductRepository(AdventureWorksSalesContext context)
        {
            _context = context;
        }

        public bool AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Product GetProductById(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetProductByName(string name)
        {
            return _context.Product.Where(x => x.Name == name).FirstOrDefault();
        }

        public IEnumerable<Product> GetProducts()
        {
            return _context.Product;
        }
    }
}