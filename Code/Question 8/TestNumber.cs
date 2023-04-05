using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_8
{
    internal class TestNumber
    {
        private Number number;

        public TestNumber(Number number)
        {
            this.number = number;
        }

        public void Test()
        {
            Console.WriteLine("{0} squared is {1} and cube is {2}",
                number.Value, number.Square, number.Cube);
        }
    }
}
