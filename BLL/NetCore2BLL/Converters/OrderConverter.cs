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
            if (order == null)
            {
                return null;
            }
            return new Order()
            {
                Id = order.Id,
                OrderDate = order.OrderDate,
                DeliveryDate = order.DeliveryDate,
                //Customer = new CustomerConverter().Convert(order.Customer),
                CustomerId = order.CustomerId
            };
        }

        internal OrderBO Convert(Order order)
        {
            if (order == null)
            {
                return null;
            }
            return new OrderBO()
            {
                Id = order.Id,
                OrderDate = order.OrderDate,
                DeliveryDate = order.DeliveryDate,
                Customer = new CustomerConverter().Convert(order.Customer),
                CustomerId = order.CustomerId

            };
        }
    }
}
