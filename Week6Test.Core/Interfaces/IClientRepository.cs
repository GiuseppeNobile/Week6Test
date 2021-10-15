using System;
using System.Collections.Generic;
using System.Text;
using Week6Test.Core.Models;

namespace Week6Test.Core.Interfaces
{
    public interface IClientRepository : IRepository<Client>
    {
        Client GetClientByID(int id);
    }
}
