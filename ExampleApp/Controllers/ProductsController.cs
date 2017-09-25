using ExampleApp.Infrastructure;
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
        IRepository repo;

        public ProductsController(IRepository repoImpl)
        {
            repo = repoImpl;
        }

        public IHttpActionResult GetAll()
        {
            return Ok(repo.Products);
        }

        public IHttpActionResult Delete(int id)
        {
            repo.DeleteProduct(id);
            //return StatusCode(HttpStatusCode.NoContent);
            //return ResponseMessage(new HttpResponseMessage(HttpStatusCode.NoContent));
            return new NoContentResult();
        }

        [HttpGet]
        [Route("api/products/noop")]
        public IHttpActionResult NoOp()
        {
            return Ok();
        }
    }
}
