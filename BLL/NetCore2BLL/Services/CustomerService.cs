using NetCore2BLL.BusinessObjects;
using NetCore2BLL.Converters;
using NetCore2DAL;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NetCore2BLL.Services
{
    public class CustomerService : ICustomerService
    {
        CustomerConverter conv = new CustomerConverter();
        DalFacade facade;

        public CustomerService(DalFacade facade)
        {
            this.facade = facade;
        }

        public CustomerBO Create(CustomerBO cust)
        {
            using (var uow = facade.UnitOfWork)
            {
                var newCust = uow.CustomerRepository.Create(conv.Convert(cust));
                uow.Complete();
                return conv.Convert(newCust);
            }
        }

        public void CreateAll(List<CustomerBO> custs)
        {
            using (var uow = facade.UnitOfWork)
            {
                foreach (var cust in custs)
                {
                    uow.CustomerRepository.Create(conv.Convert(cust));
                }
                uow.Complete();
            }
        }

        public CustomerBO Delete(int Id)
        {
            using (var uow = facade.UnitOfWork)
            {
                var deletedCust = uow.CustomerRepository.Delete(Id);
                uow.Complete();
                return conv.Convert(deletedCust);
            }
        }

        public CustomerBO Get(int Id)
        {
            using (var uow = facade.UnitOfWork)
            {
                return conv.Convert(uow.CustomerRepository.Get(Id));
            }
        }

        public List<CustomerBO> GetAll()
        {
            using (var uow = facade.UnitOfWork)
            {
                //Customer -> CustomerBO
                //return uow.CustomerRepository.GetAll();
                return uow.CustomerRepository.GetAll().Select(conv.Convert).ToList();
            }
        }

        public CustomerBO Update(CustomerBO cust)
        {
            using (var uow = facade.UnitOfWork)
            {
                var customerFromDb = uow.CustomerRepository.Get(cust.Id);
                if (customerFromDb == null)
                {
                    throw new InvalidOperationException("Customer not found");
                }

                customerFromDb.FirstName = cust.FirstName;
                customerFromDb.LastName = cust.LastName;
                customerFromDb.Address = cust.Address;
                uow.Complete();
                return conv.Convert(customerFromDb);
            }

        }
    }
}
