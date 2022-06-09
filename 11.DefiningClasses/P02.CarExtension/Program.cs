using System;

namespace CarManufacturer
{
    class Car
    {
        private string make;
        private string model;
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private double fuelQuantity;

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }

        private double fuelConsumption;
        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public void Drive(double distnace)
        {
            double consumption = distnace * this.FuelConsumption;
            if (consumption <= this.fuelQuantity)
            {
                this.FuelQuantity -= consumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            string carInfo =
                $"Make: {this.make}\r\n" +
                $"Model: {this.Model}\r\n" +
                $"Year: {this.Year}\r\n" +
                $"Fuel: {this.FuelQuantity:F2}L";
            return carInfo;
        }

    }
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "BMW";
            car.Model = "X6";
            car.Year = 2022;
            car.FuelQuantity = 50;
            car.FuelConsumption = 0.07;
            Console.WriteLine(car.WhoAmI());
            Console.WriteLine();

            car.Drive(700);
            Console.WriteLine(car.WhoAmI());
            Console.WriteLine();

            car.Drive(50);
            Console.WriteLine(car.WhoAmI());
            Console.WriteLine();
        }
    }
}
