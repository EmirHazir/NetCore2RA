using System;
using System.Collections.Generic;
using NetCore2DAL.Entities;
using NetCore2DAL.Context;
using System.Linq;

namespace NetCore2DAL.Repositories
{
    public class OrderRepository : IOrderRepository
    {

        CustomerAppContext _context;
        public OrderRepository(CustomerAppContext context)
        {
            _context = context;
        }


        public Order Create(Order order)
        {
            _context.Orders.Add(order);
            return order;
        }

        public Order Delete(int Id)
        {
            var order = Get(Id);
            _context.Orders.Remove(order);
            return order;
        }

        public Order Get(int Id)
        {
            return _context.Orders.FirstOrDefault(x => x.Id == Id);
        }

        public List<Order> GetAll()
        {
            return _context.Orders.ToList();
        }
    }
}
