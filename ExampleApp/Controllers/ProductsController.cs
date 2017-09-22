using ExampleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExampleApp.Controllers
{
    public class ProductsController : ApiController
    {
        Repository repo;

        public ProductsController()
        {
            repo = Repository.Current;
        }

        public IEnumerable<Product> GetAll()
        {
            return repo.Products;
        }
    }
}
