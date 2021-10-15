using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Week6Test.Core;
using Week6Test.Core.BusinessLayers;
using Week6Test.Core.Interfaces;
using Week6Test.Core.Models;
using Week6Test.EF.Repositories;

namespace Week6Test.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class GestioneOrdiniService : IGestioneOrdiniService
    {
        IMainBusinessLayer mainBL;

        public GestioneOrdiniService()
        {
            DependencyContainer.Register<IMainBusinessLayer, MainBusinessLayer>();
            DependencyContainer.Register<IClientRepository, EFClientRepository>();
            DependencyContainer.Register<IOrderRepository, EFOrderRepository>();

            this.mainBL = DependencyContainer.Resolve<IMainBusinessLayer>();


        }

        public bool CreateClient(Client newClient)
        {
            if (newClient == null)
                return false;

            return this.mainBL.CreateClient(newClient);
        }

        public bool DeleteClientById(int id)
        {
            if (id > 0)
                return this.mainBL.DeleteClientById(id);

            return false;
        }

        public bool EditClient(Client editedClient)
        {
            if (editedClient == null)
                return false;

            return this.mainBL.EditClient(editedClient);
        }

        public IEnumerable<Client> FetchClients()
        {
            return this.mainBL.FetchClients();
        }
    }
}
