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
    class GroundTransport: Transport
    {
        [DataMember]
        public int Transmission
        {
            get; set;
        }
        
        public GroundTransport(  string name, int cost, Factory fact, Driver driver, string engine, int transmission): base(name, cost, fact,  driver,  engine)
        { 
            Transmission = transmission;
            
        }
    }
}
