using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_7
{
    internal class Number
    {
        private double number;

        public double Value
        {
            get
            {
                return number;
            }
            set
            {
                this.number = value;
            }
        }

        public double Square
        {
            get
            {
                return Math.Pow(number, 2);
            }
        }

        public double Cube
        {
            get
            {
                return Math.Pow(number, 3);
            }
        }

        public Number(double number)
        {
            this.number = number;
        }
    }
}
