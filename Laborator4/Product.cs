using System;

namespace Laboratorul4
{
    public class Product
    {

        public int Id { get;  set; }
        public string Name { get;  set; }
        public DateTime StartDate { get;  set; }
        public DateTime EndDate { get;  set; }
        public double Price { get;  set; }
        public double VAT { get;  set; }

        public Product(int Id, string Name, DateTime StartDate, DateTime EndDate, double Price)
        {
            this.Id = Id;
            this.Name = Name;
            this.StartDate = StartDate;
            this.EndDate = EndDate;
            this.Price = Price;
            ComputeVAT();
        }

        public bool IsValid()
        {
            if (this.Id < 0)
                return false;
            if (this.Name == null)
                return false;
            if (this.StartDate > this.EndDate)
                return false;
            if (this.Price < 0)
                return false;
            return true;
        }

        public double ComputeVAT()
        {
            VAT = Price * 0.19;
            return VAT;
        }

    }
}
