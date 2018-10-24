using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorul4
{
    class CustomerRepository
    {
        private readonly ProductManagement _context;
        public CustomerRepository()
        {
            this._context = new ProductManagement();
        }

        public void Create(Customer customer)
        {
            _context.Customer.Add(customer);
            _context.SaveChanges();
        }
        public void Update(Customer customer)
        {
            _context.Customer.Update(customer);
            _context.SaveChanges();
        }
        public void Delete(Customer customer)
        {
            _context.Customer.Remove(customer);
            _context.SaveChanges();
        }
        public Customer GetById(int id)
        {
            return this._context.Customer.Find(t => t.id == id);
        }
        public List<Customer> GetAll()
        {
            List<Customer> c = new List<Customer>();

            foreach (Customer customer in _context.Customers)
            {
                c.Add(customer);
            }
            return c;
        }
    }
}
