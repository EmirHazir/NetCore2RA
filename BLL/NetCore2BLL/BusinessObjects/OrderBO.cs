using System;

namespace NetCore2BLL.BusinessObjects
{
    public class OrderBO
    {
        public int Id { get; set; }

        public DateTime OrderDate { get; set; }

        public DateTime DeliveryDate { get; set; }

        public int CustomerId { get; set; }

        public CustomerBO Customer { get; set; }
    }
}
