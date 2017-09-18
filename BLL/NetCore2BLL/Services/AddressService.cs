using System;
using System.Collections.Generic;
using System.Text;
using NetCore2BLL.BusinessObjects;
using NetCore2BLL.Converters;
using NetCore2DAL;

namespace NetCore2BLL.Services
{
    public class AddressService : IAddressService
    {
        AddressConverter _conv;
        DalFacade _facade;

        public AddressService(DalFacade facade)
        {
            _facade = facade;
            _conv = new AddressConverter();
        }


        public AddressBO Create(AddressBO address)
        {
            throw new NotImplementedException();
        }

        public AddressBO Delete(int id)
        {
            throw new NotImplementedException();
        }

        public AddressBO Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<AddressBO> GetAll()
        {
            throw new NotImplementedException();
        }

        public AddressBO Update(AddressBO address)
        {
            throw new NotImplementedException();
        }
    }
}
