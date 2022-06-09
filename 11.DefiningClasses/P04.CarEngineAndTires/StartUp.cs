using System;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            car.Drive(700);
            Console.WriteLine(car.WhoAmI());
            Console.WriteLine();

            car.Drive(50);
            Console.WriteLine(car.WhoAmI());
            Console.WriteLine();

            Engine lamboEngine = new Engine(560, 6300);
            var lamboTires = new Tire[4]
            {
                new Tire(1, 2.4),
                new Tire(1, 2.3),
                new Tire(2, 2.4),
                new Tire(2, 2.6),
            };
            Car lambo = new Car("Lambo", "Urus", 2010, 250, 0.12, lamboEngine, lamboTires);

            lambo.Drive(50);
            Console.WriteLine(lambo.WhoAmI());
           
        }
    }
}
