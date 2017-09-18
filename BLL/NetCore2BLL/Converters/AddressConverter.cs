using NetCore2BLL.BusinessObjects;
using NetCore2DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore2BLL.Converters
{
   public class AddressConverter
    {
         internal Address Convert(AddressBO address)
        {
            if (address == null)
            {
                return null;
            }
            return new Address()
            {
                Id = address.Id,
                City = address.City,
                Number = address.Number,
                Street = address.Street
            };
        } 



        internal AddressBO Convert(Address address)
        {
            if (address == null)
            {
                return null;
            }
            return new Address()
            {
                Id = address.Id,
                City = address.City,
                Number = address.Number,
                Street = address.Street
            };
        }
    }
}
