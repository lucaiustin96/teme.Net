using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorul4
{
    public interface IProductRepository
    {
        void Create(Product product);
        void Update(Product product);
        void Delete(Product product);
        Product GetById(int id);
        List<Product> GetAll();
    }
}
