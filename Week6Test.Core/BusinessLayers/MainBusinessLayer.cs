using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Week6Test.Core.Interfaces;
using Week6Test.Core.Models;

namespace Week6Test.Core.BusinessLayers
{
    public class MainBusinessLayer : IMainBusinessLayer
    {
        private readonly IClientRepository clientRepo;
        private readonly IOrderRepository orderRepo;

        #region Clients
        public bool CreateClient(Client newClient)
        {
            if (newClient == null)
                return false;

            return clientRepo.Add(newClient);
        }       

        public bool DeleteClientById(int id)
        {
            if (id <= 0)
                return false;

            Client clientToBeDeleted = this.clientRepo.GetClientByID(id);

            if (clientToBeDeleted != null)
                return clientRepo.Delete(clientToBeDeleted);

            return false;
        }

        public bool EditClient(Client editedClient)
        {
            if (editedClient == null)
                return false;

            return clientRepo.Update(editedClient);
        }

        public Client FetchClientById(int id)
        {
            if (id <= 0)
                return null;

            return clientRepo.GetClientByID(id);
        }

        public IEnumerable<Client> FetchClients(Func<Client, bool> filter = null)
        {
            if (filter != null)
                return clientRepo.Fetch().Where(filter);

            return clientRepo.Fetch();
        }

        
        
        #endregion

        #region Orders
        public bool CreateOrder(Order newOrder)
        {
            if (newOrder == null)
                return false;

            return orderRepo.Add(newOrder);
        }

        public bool DeleteOrderById(int id)
        {
            if (id <= 0)
                return false;

            Order orderToBeDeleted = this.orderRepo.GetOrderByID(id);

            if (orderToBeDeleted != null)
                return orderRepo.Delete(orderToBeDeleted);

            return false;
        }

        public Order FetchOrderById(int id)
        {
            if (id <= 0)
                return null;

            return orderRepo.GetOrderByID(id);
        }

        public IEnumerable<Order> FetchOrders(Func<Order, bool> filter = null)
        {
            if (filter != null)
                return orderRepo.Fetch().Where(filter);

            return orderRepo.Fetch();
        }
        #endregion
    }
}
