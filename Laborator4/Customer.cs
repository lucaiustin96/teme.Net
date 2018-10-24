namespace Laboratorul4
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }

        public Customer(int Id, string Name, string Address, int PhoneNumber, string Email)
        {
            this.Id = Id;
            this.Name = Name;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
            this.Email = Email;
        }
    }
}
