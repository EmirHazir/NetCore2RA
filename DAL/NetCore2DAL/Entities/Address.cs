using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore2DAL.Entities
{
    public class Address
    {
        public int Id { get; set; }

        public string Street { get; set; }

        public string Number { get; set; }

        public string City { get; set; }

        //bir adresin birden çok sahibi olabillir
        public List<Customer> Customers { get; set; }
    }
}
