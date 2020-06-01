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
    class Factory
    {
        [DataMember]
        public string City
        {
            get; set;
        }
        [DataMember]
        public string Name1
        {
            get; set;
        }
       
        public Factory(string city, string name1)
        {
            City = city;
            Name1 = name1; 
        }
    }
}
