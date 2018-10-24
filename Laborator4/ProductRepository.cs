using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorul4
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductManagement _context;

        public ProductRepository()
        {
            this._context = new ProductManagement();
        }

        public void Create(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }
        public void Update(Product product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }
        public void Delete(Product product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }
        public Product GetById(int id)
        {
            return this._context.Products.Find(t => t.id== id);
        }
        public List<Product> GetAll()
        {
            List<Product> p = new List<Product>();

            foreach(Product product in _context.Products)
            {
                p.Add(product);
            }
            return p;
        }
    }
}
