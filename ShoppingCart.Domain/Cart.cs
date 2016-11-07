using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Domain
{
    public class Cart
    {
        public int ID { get; set; }
        public DateTime CartDate { get; set; }

        [NotMapped]
        public Decimal CartTotalPrice
        {
            get
            {
                Decimal total = 0;
                foreach (var item in CartItens)
                {
                    total += item.ItemTotalPrice;
                }
                return total;
            }
        }

        public virtual List<CartItem> CartItens { get; set; }
        public virtual PaymentInformation PaymentInformation { get; set; }
    }
}
