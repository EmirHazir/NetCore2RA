using Microsoft.EntityFrameworkCore;
using NetCore2DAL.Entities;

namespace NetCore2DAL.Context
{
    public class CustomerAppContext : DbContext
    {
        static DbContextOptions<CustomerAppContext> options =
            new DbContextOptionsBuilder<CustomerAppContext>()
                         .UseInMemoryDatabase("TheDB")
                         .Options;

        public CustomerAppContext() : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
