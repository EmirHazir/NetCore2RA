using NetCore2BLL.BusinessObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore2BLL
{
   public interface IOrderService
    {
        //C
        OrderBO Create(OrderBO order);
        //R
        List<OrderBO> GetAll();
        OrderBO Get(int Id);
        //U
        OrderBO Update(OrderBO order);
        //D
        OrderBO Delete(int Id);
    }
}
