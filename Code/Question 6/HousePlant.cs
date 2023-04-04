using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Question_6
{
    internal class HousePlant
    {
        private string name;
        private double price;
        private bool fed;

        public string Name
        {
            get
            {
                return name;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                // Make sure to round to 2 decimal places
                this.price = Math.Round(value, 2);
            }
        }

        public bool Fed
        {
            get
            {
                return fed;
            }
        }

        public void Feed()
        {
            fed = true;
        }

        public HousePlant(string name, double price, bool fed)
        {
            this.name = name;
            this.price = price;
            this.fed = fed;
        }

        // Reuse the above constructor
        // to create a plant that has no price
        // and has not been fed
        public HousePlant(string name) : this(name, 0, false)
        {
            // Empty
        }
    }
}
