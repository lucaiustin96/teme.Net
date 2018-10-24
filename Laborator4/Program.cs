using System;

namespace Laboratorul4
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductRepository productRepository = new ProductRepository();
            Product product = new Product(1, "Mar", new DateTime(2018, 02, 01), new DateTime(2018, 02, 01), 100);
            Product product1 = new Product(1, "Mar1", new DateTime(2018, 02, 01), new DateTime(2018, 02, 01), 100);
            productRepository.Create(product);
            productRepository.Create(product1);
            product1.Name = "Mar2";
            productRepository.Update(product1);
        }
    }
}
