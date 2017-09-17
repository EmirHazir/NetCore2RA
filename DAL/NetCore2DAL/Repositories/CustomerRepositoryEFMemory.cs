using System.Collections.Generic;
using NetCore2DAL.Entities;
using NetCore2DAL.Context;
using System.Linq;

namespace NetCore2DAL.Repositories
{
    public class CustomerRepositoryEFMemory : ICustomerRepository
    {

        CustomerAppContext _context;
        public CustomerRepositoryEFMemory(CustomerAppContext context)
        {
            _context = context;
        }

        public Customer Create(Customer cust)
        {
            _context.Customers.Add(cust);
            return cust;
        }

        public Customer Delete(int Id)
        {
            var cust = Get(Id);
            _context.Customers.Remove(cust);
            return cust;
        }

        public Customer Get(int Id)
        {
            return _context.Customers.FirstOrDefault(x => x.Id == Id);
        }

        public List<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }
    }
}
