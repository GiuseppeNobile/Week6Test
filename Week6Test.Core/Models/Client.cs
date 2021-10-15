using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Week6Test.Core.Models
{
    [DataContract]
    public class Client
    {
        [DataMember]
        public int ClientID { get; set; }

        [DataMember]
        public string ClientCode { get; set; }

        [DataMember]
        public string Nome { get; set; }

        [DataMember]
        public string Cognome { get; set; }

        public List<Order> Orders { get; set; }
    }
}
