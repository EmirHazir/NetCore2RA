using NetCore2BLL.BusinessObjects;
using NetCore2DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore2BLL.Converters
{
   public class OrderConverter
    {
        internal Order Convert(OrderBO order)
        {
            return new Order()
            {
                Id = order.Id,
                OrderDate = order.OrderDate,
                DeliveryDate = order.DeliveryDate
                
            };
        }

        internal OrderBO Convert(Order order)
        {
            return new OrderBO()
            {
                Id = order.Id,
                OrderDate = order.OrderDate,
                DeliveryDate = order.DeliveryDate

            };
        }
    }
}
