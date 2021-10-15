using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Week6Test.Core.Interfaces;
using Week6Test.Core.Models;

namespace Week6Test.EF.Repositories
{
    public class EFClientRepository : IClientRepository
    {
        private readonly GestioneOrdiniContext ctx;

        public EFClientRepository() : this(new GestioneOrdiniContext()) { }

        public EFClientRepository(GestioneOrdiniContext ctx)
        {
            this.ctx = ctx;
        }

        public bool Add(Client newClient)
        {
            if (newClient == null)
                return false;

            try
            {
                ctx.Clients.Add(newClient);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public bool Delete(Client delClient)
        {
            if (delClient == null)
                return false;

            try
            {
                var clientId = ctx.Clients.Find(delClient.ClientID);

                if (clientId == null)
                    ctx.Clients.Remove(clientId);

                ctx.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public List<Client> Fetch(Func<Client, bool> filter = null)
        {
            try
            {
                if (filter != null)
                    return ctx.Clients.Where(filter).ToList();

                return ctx.Clients.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return new List<Client>();
            }
        }

        public Client GetClientByID(int id)
        {
            if (id <= 0)
                return null;

            return ctx.Clients.Find(id);
        }

        public bool Update(Client updateClient)
        {
            if (updateClient == null)
                return false;

            try
            {
                ctx.Clients.Update(updateClient);
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
