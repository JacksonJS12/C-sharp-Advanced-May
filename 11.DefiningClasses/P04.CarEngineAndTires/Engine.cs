using System;
using System.Collections.Generic;
using System.Text;

namespace CarManufacturer
{
    public class Engine
    {
        public int HorsePoweer { get; set; }
        public double cubicCapacity { get; set; }

        public Engine(int horsePoweer, double cubicCapacity)
        {
            this.HorsePoweer = horsePoweer;
            this.cubicCapacity = cubicCapacity;
        }
    }
}