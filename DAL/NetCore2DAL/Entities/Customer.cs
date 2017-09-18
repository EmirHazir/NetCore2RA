using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore2DAL.Entities
{
    public class Customer
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Address { get; set; }

        //bir müşterinin birden fazla siparişi olur
        public List<Order> Orders { get; set; }

        //Bir müşterinin de birden fazla adresi olabilit
        public List<Address> Addresses { get; set; }
    }
}
