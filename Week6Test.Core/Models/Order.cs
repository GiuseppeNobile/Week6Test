using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Week6Test.Core.Models
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public int OrderID { get; set; }

        [DataMember]
        public DateTime OrderDate { get; set; }

        [DataMember]
        public string OrderCode { get; set; }

        [DataMember]
        public string ProductCode { get; set; }

        [DataMember]
        public decimal Price { get; set; }

        public Client Client { get; set; }
    }
}
