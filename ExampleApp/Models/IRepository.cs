using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleApp.Models
{
    public interface IRepository
    {
        IEnumerable<Product> Products { get; }
        Product GetProduct(int id);
        Product SaveProduct(Product newProduct);
        Product DeleteProduct(int id);
    }
}
