using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Week6Test.Core.Interfaces;
using Week6Test.Core.Models;

namespace Week6Test.EF.Repositories
{
    public class EFOrderRepository : IOrderRepository
    {
        private readonly GestioneOrdiniContext ctx;

        public EFOrderRepository() : this(new GestioneOrdiniContext()) { }

        public EFOrderRepository(GestioneOrdiniContext ctx)
        {
            this.ctx = ctx;
        }

        public bool Add(Order newOrder)
        {
            if (newOrder == null)
                return false;

            try
            {
                ctx.Orders.Add(newOrder);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool Delete(Order delOrder)
        {
            if (delOrder == null)
                return false;

            try
            {
                var orderId = ctx.Orders.Find(delOrder.OrderID);

                if (orderId == null)
                    ctx.Orders.Remove(orderId);

                ctx.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public List<Order> Fetch(Func<Order, bool> filter = null)
        {
            try
            {
                if (filter != null)
                    return ctx.Orders.Where(filter).ToList();

                return ctx.Orders.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<Order>();
            }
        }

        public Order GetOrderByID(int id)
        {
            if (id <= 0)
                return null;

            return ctx.Orders.Find(id);
        }

        public bool Update(Order updateOrder)
        {
            if (updateOrder == null)
                return false;

            try
            {
                ctx.Orders.Update(updateOrder);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
