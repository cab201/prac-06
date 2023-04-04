using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
{
    internal class Car
    {
        // Fields should always start private
        private string model;
        private int efficiency; // liters per km

        // Constructor with both fields
        public Car(string model, int efficiency)
        {
            this.model = model;
            this.efficiency = efficiency;
        }

        // Constructor with just the model
        public Car(string model)
        {
            this.model = model;
            this.efficiency = 50;
        }

        public void Display()
        {
            Console.WriteLine("Model {0}, Efficiency {1} L/km",
                model, efficiency);
        }
    }
}
