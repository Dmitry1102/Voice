using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_2_OOTP
{
    class Driver
    {
        public string Name2
        {
            get; set;
        }
        public string Surname
        {
            get; set;
        }

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
