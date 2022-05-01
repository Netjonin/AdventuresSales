using AdventureWorksSales.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureWorksSales.Web.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);
        Product GetProductByName(string name);
        bool AddProduct(Product product);
    }
}
