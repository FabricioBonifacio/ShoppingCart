using ShoppingCart.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Repository.Context
{
    class ShoppingCartContext : DbContext
    {
        public ShoppingCartContext() : base("Data Source=.\\SQLEXPRESS; Database=ShoppingCart ;User Id=sa; Password=root;")
        {
        }

        public DbSet<PaymentInformation> Billing { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Cart> Cart { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
