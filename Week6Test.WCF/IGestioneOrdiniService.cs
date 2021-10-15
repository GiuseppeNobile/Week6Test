using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Week6Test.Core.Models;

namespace Week6Test.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IGestioneOrdiniService
    {
        [OperationContract]
        IEnumerable<Client> FetchClients();

        [OperationContract]
        bool CreateClient(Client newClient);

        [OperationContract]
        bool EditBook(Client editedCLient);

        [OperationContract]
        bool DeleteClientById(int id);

    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "Week6Test.WCF.ContractType".

}
