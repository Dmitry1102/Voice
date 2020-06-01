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
    class Driver
    {
        [DataMember]
        public string Name2
        {
            get; set;
        }
        [DataMember]
        public string Surname
        {
            get; set;
        }
        [DataMember]
        public string Category
        {
            get; set;
        }
        public Driver(string name2, string surname, string category)
        {
            Name2 = name2;
            Surname = surname;
            Category = category;
        }
    }
}
