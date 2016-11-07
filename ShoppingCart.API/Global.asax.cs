using ShoppingCart.Domain;
using ShoppingCart.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Routing;

namespace ShoppingCart.API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            createProducts();
        }

        private void createProducts()
        {
            ProductRepository repository = new ProductRepository();
            repository.Save(new Product { ID = 1, Name = "Umbrella", Price = 5.90M });
            repository.Save(new Product { ID = 2, Name = "Christmas Tree", Price = 21.30M });
            repository.Save(new Product { ID = 3, Name = "T-Shirt", Price = 7.10M });
            repository.Save(new Product { ID = 4, Name = "Candy", Price = 2.40M });
            repository.Save(new Product { ID = 5, Name = "Cake", Price = 11.20M });
            repository.Save(new Product { ID = 6, Name = "Pen Drive", Price = 33.70M });
            repository.Save(new Product { ID = 7, Name = "Telephone", Price = 54.20M });
            repository.Save(new Product { ID = 8, Name = "Coffee", Price = 3.45M });
            repository.Save(new Product { ID = 9, Name = "Chocolate", Price = 1.80M });
        }
    }
}
