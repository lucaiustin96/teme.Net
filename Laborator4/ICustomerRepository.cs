using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorul4
{
    public interface ICustomerRepository
    {
        void Create(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
        Customer GetById(int id);
        List<Customer> GetAll();
    }
}
