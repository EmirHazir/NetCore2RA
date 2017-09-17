using NetCore2DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore2DAL
{
    public interface IOrderRepository
    {
        Order Create(Order order);
        //R
        List<Order> GetAll();
        Order Get(int Id);
        //U
        //No Update for Repository, It will be the task of Unit of Work
        //D
        Order Delete(int Id);
    }
}
