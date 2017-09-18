using System;
using System.Collections.Generic;
using System.Text;
using NetCore2BLL.BusinessObjects;
using NetCore2BLL.Converters;
using NetCore2DAL;
using System.Linq;

namespace NetCore2BLL.Services
{
    public class OrderService : IOrderService
    {
        OrderConverter conv = new OrderConverter();
        private DalFacade _facade;

        public OrderService(DalFacade facade)
        {
            this._facade = facade;
        }

        public OrderBO Create(OrderBO order)
        {
            using (var uow = _facade.UnitOfWork)
            {
                var newOrder = uow.OrderRepository.Create(conv.Convert(order));
                uow.Complete();
                return conv.Convert(newOrder);
            }
        }

        public OrderBO Delete(int Id)
        {
            using (var uow = _facade.UnitOfWork)
            {
                var deletedOrder = uow.OrderRepository.Delete(Id);
                uow.Complete();
                return conv.Convert(deletedOrder);
            }
        }

        public OrderBO Get(int Id)
        {
            using (var uow = _facade.UnitOfWork)
            {
                var orderEntity = uow.OrderRepository.Get(Id);
                orderEntity.Customer = uow.CustomerRepository.Get(orderEntity.CustomerId);

                return conv.Convert(orderEntity);
            }
        }

        public List<OrderBO> GetAll()
        {
            using (var uow = _facade.UnitOfWork)
            {
                return uow.OrderRepository.GetAll().Select(conv.Convert).ToList();
            }
        }

        public OrderBO Update(OrderBO order)
        {
            using (var uow = _facade.UnitOfWork)
            {
                var orderFromDb = uow.OrderRepository.Get(order.Id);
                if (orderFromDb == null)
                {
                    throw new InvalidOperationException("order not found");
                }

                orderFromDb.DeliveryDate = order.DeliveryDate;
                orderFromDb.OrderDate = order.OrderDate;
                orderFromDb.CustomerId = order.CustomerId;
                uow.Complete();

                orderFromDb.Customer = uow.CustomerRepository.Get(orderFromDb.CustomerId);
                return conv.Convert(orderFromDb);
            }
        }
    }
}
