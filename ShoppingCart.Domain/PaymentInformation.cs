using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Domain
{
    public class PaymentInformation
    {
        public int ID { get; set; }
        public int Parcels { get; set; }
        public String CreditCardNumber { get; set; }
        public String ExpirationDate { get; set; }
        public String CreditCardOwnerName { get; set; }
        public String SecurityCode { get; set; }
        public String Address { get; set; }
        public String Complement { get; set; }
        public String City { get; set; }
        public String State { get; set; }
        public String Country { get; set; }
        public int CartID { get; set; }
    }
}
