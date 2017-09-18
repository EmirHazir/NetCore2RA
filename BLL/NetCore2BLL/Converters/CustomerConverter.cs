using NetCore2BLL.BusinessObjects;
using NetCore2DAL.Entities;
using System.Linq;

namespace NetCore2BLL.Converters
{
    public class CustomerConverter
    {

        private AddressConverter aConv;
        internal Customer Convert(CustomerBO cust)
        {
            if (cust == null)
            {
                return null;
            }
            return new Customer()
            {
                Id = cust.Id,
                Addresses = cust.Addresses.Select(aConv.Convert).ToList(),
                FirstName = cust.FirstName,
                LastName = cust.LastName
            };
        }

        internal CustomerBO Convert(Customer cust)
        {
            if (cust == null)
            {
                return null;
            }
            return new CustomerBO()
            {
                Id = cust.Id,
                Addresses = cust.Addresses.Select(aConv.Convert).ToList(),
                FirstName = cust.FirstName,
                LastName = cust.LastName
            };
        }
    }
}
