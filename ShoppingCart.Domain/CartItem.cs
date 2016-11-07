using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Domain
{
    public class CartItem
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public int CartID { get; set; }

        [NotMapped]
        public Decimal ItemTotalPrice {
            get
            {
                return Quantity * Product.Price;
            }
        }

        public virtual Product Product { get; set; }
    }
}
