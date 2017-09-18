using NetCore2BLL.Services;
using NetCore2DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore2BLL
{
   public class BLLFacade
    {
        public ICustomerService CustomerService
        {
            get { return new CustomerService(new DalFacade()); }
        }

        public IOrderService OrderService
        {
            get { return new OrderService(new DalFacade()); }
        }

        public IAddressService AddressService
        {
            get { return new AddressService(new DalFacade()); }
        }
    }
}
