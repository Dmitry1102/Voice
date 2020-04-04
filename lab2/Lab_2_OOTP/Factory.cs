using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_OOTP
{
    class Factory
    {
        public string City
        {
            get; set;
        }
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
