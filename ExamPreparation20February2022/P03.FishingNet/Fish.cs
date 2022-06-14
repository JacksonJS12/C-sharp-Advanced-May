
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingNet
{
    class Fish
    {
        private string fishType;
        private double lenght;
        private double weight;

        public string FishType
        {
            get { return fishType; }
            set { fishType = value; }
        }
        public double Lenght
        {
            get { return lenght; }
            set { lenght = value; }
        }
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public Fish(string fishType, double lenght, double weight)
        {
            this.FishType = fishType;
            this.Lenght = lenght;
            this.Weight = weight;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"There is a {this.FishType}, {this.Lenght} cm. long, and {this.Weight} gr. in weight.");

            return sb.ToString();
        }
    }
}
