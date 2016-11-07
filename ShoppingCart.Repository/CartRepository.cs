using ShoppingCart.Domain;
using ShoppingCart.Repository.Context;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Repository
{
    public class CartRepository : IRepository<Cart>, IDisposable
    {
        private ShoppingCartContext _context;

        public List<Cart> GetAll()
        {
            using (_context = new ShoppingCartContext())
            {
                return _context.Cart.Include(path => path.CartItens).Include(p => p.PaymentInformation).ToList();
            }
        }

        public void Save(Cart Cart)
        {
            try
            {
                using (_context = new ShoppingCartContext())
                {

                    _context.Cart.Add(Cart);
                    if (Cart.ID > 0)
                    {
                        _context.Entry(Cart).State = EntityState.Modified;
                    }
                    _context.SaveChanges();

                }

            }
            catch (Exception ex)
            {

            }
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}
