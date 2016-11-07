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
    public class ProductRepository : IRepository<Product>, IDisposable
    {
        private ShoppingCartContext _context;

        public List<Product> GetAll()
        {
            using (_context = new ShoppingCartContext())
            {
                return _context.Product.ToList();
            }
        }

        public void Save(Product Product)
        {
            try
            {
                using (_context = new ShoppingCartContext())
                {

                    _context.Product.Add(Product);
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
