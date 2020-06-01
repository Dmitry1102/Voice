using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Lab_2_OOTP
{
    [Serializable]
    [DataContract]
    class AirTransport :Transport
    {
        [DataMember]
        public int Capacity
        {
            get; set;
        }
        [DataMember]
        public int Weight
        {
            get; set;
        }
        public AirTransport( string name, int cost, Factory fact, Driver driver, string engine, int capacity, int weight) : base(name, cost, fact, driver, engine)
        {
            Capacity = capacity;
            Weight = weight;
        }

    }
}
