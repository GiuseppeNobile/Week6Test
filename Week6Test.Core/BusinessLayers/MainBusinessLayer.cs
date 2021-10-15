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
            throw new NotImplementedException();
        }

        public bool DeleteOrderById(int id)
        {
            throw new NotImplementedException();
        }

        public Order FetchOrderById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> FetchOrders(Func<Order, bool> filter = null)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
