using ShoppingCart.Domain;
using ShoppingCart.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ShoppingCart.API.Controllers
{
    public class ProductController : ApiController
    {
        ProductRepository repository = new ProductRepository();
        // GET: api/Product
        public List<Product> Get()
        {
            return repository.GetAll();
        }
        
    }
}
