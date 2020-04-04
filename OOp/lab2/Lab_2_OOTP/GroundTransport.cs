using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_OOTP
{
    class GroundTransport: Transport
    {
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
