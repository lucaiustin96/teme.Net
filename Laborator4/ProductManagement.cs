using Microsoft.EntityFrameworkCore;

namespace Laboratorul4
{
    class ProductManagement : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(LocalDB)\ProjectsV13;Database=tempdb;Trusted_Connection=True;");
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(product => product.Name)
                .IsRequired()
                .HasMaxLength(50);

            modelBuilder.Entity<Product>()
               .Property(product => product.StartDate)
               .IsRequired();

            modelBuilder.Entity<Product>()
                   .Property(product => product.EndDate)
                   .IsRequired();

            modelBuilder.Entity<Product>()
                .Property(product => product.Price)
                .IsRequired();

            modelBuilder.Entity<Product>()
                .Property(product => product.VAT)
                .IsRequired();

            modelBuilder.Entity<Customer>()
                .Property(customer => customer.Name)
                .IsRequired()
                .HasMaxLength(100);
            modelBuilder.Entity<Customer>()
                .Property(customer => customer.Address)
                .IsRequired()
                .HasMaxLength(300);

            modelBuilder.Entity<Customer>()
                .Property(customer => customer.PhoneNumber)
                .IsRequired();
            // expresie regulara


            modelBuilder.Entity<Customer>()
                .Property(customer => customer.Email)
                .IsRequired();
            // expresie regulara

        }
    }
}
