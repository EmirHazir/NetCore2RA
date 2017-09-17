using System;
using System.Collections.Generic;
using System.Text;

namespace NetCore2DAL
{
   public interface IUOW : IDisposable
    {
        ICustomerRepository CustomerRepository { get; }
        IOrderRepository OrderRepository { get; }

        int Complete();

    }
}
