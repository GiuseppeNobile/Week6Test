using System;
using System.Collections.Generic;
using System.Text;
using Week6Test.Core.Models;

namespace Week6Test.Core.Interfaces
{
    public interface IOrderRepository : IRepository<Order>
    {
        Order GetOrderByID(int id);
    }
}
