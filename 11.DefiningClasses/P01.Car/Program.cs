using System;

namespace CarManufacturer
{
    class Car
    {
        public Car()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;

            Console.WriteLine($"Make: {this.Make}\nModel: {this.Model}\nYear: {this.Year}");
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        private string make { get; set; }
        private string model { get; set; }
        private int year { get; set; }

    }
    public class StartUp
    {
        static void Main(string[] args)
        {
            Car car = new Car();
        }
    }
}
