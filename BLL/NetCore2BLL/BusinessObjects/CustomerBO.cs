using System.Collections.Generic;

namespace NetCore2BLL.BusinessObjects
{
    public class CustomerBO
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }

        }

        public List<AddressBO> Addresses { get; set; }
    }
}
