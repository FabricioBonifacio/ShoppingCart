using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Repository
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        void Save(T entity);
    }
}
