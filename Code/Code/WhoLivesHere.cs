using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code
{
    class WhoLivesHere
    {
        public string name;
        public string city;
        public void Display()
        {
            Console.WriteLine
                ("Hello! My name is {0} " +
                "and I live in {1}",
                name, city);
        }
    }
}
