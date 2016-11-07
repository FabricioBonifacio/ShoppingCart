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
    public class CartController : ApiController
    {
        CartRepository repository = new CartRepository();

        // POST: api/Cart
        [HttpPost]
        public HttpResponseMessage Post([FromBody] Cart cart)
        {
            try
            {
                cart.CartDate = DateTime.Now;
                repository.Save(cart);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }

        }
    }
}
