using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Domain
{
    public class Product
    {
        public int ID { get; set; }
        public String Name { get; set; }
        public Decimal Price { get; set; }
    }
}
