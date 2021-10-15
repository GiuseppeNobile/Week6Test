using System;
using System.Collections.Generic;
using System.Text;
using Week6Test.Core.Models;

namespace Week6Test.Core.Interfaces
{
    public interface IMainBusinessLayer
    {
        #region Client
        IEnumerable<Client> FetchClients(Func<Client, bool> filter = null);
        Client FetchClientById(int id);
        bool CreateClient(Client newClient);
        bool EditClient(Client editedClient);
        bool DeleteClientById(int id);
        #endregion

        #region Order
        IEnumerable<Order> FetchOrders(Func<Order, bool> filter = null);
        Order FetchOrderById(int id);
        bool CreateOrder(Order newOrder);        
        bool DeleteOrderById(int id);
        #endregion
    }
}
