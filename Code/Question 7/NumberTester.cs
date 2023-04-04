using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_7
{
    internal class NumberTester
    {
        private Number number;

        public NumberTester(Number number)
        {
            this.number = number;
        }

        public void Test()
        {
            Console.WriteLine("Number: {0}, Square: {1}, Cube: {2}",
                number.Value, number.Square, number.Cube);
        }
    }
}
