using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore2DAL.Entities
{
   public class Order
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public int CustomerId { get; set; }

        //Bir şiparişin bir müşterisi olur
        public Customer Customer { get; set; }
    }
}
