using NetCore2BLL.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore2BLL
{
   public interface IAddressService
    {
        AddressBO Create(AddressBO address);

        List<AddressBO> GetAll();

        AddressBO Get(int id);

        AddressBO Update(AddressBO address);

        AddressBO Delete(int id);
    }
}
