using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_8
{
    internal class Number
    {
        private double value;

        public double Value
        {
            get
            {
                return this.value;
            }
            set
            {
                this.value = value;
            }
        }

        public double Square
        {
            get
            {
                return Math.Pow(this.value, 2);
            }
        }

        public double Cube
        {
            get
            {
                return Math.Pow(this.value, 4);
            }
        }

        public Number(double value)
        {
            Value = value;
        }
    }
}
