using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main()
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string carInfo = Console.ReadLine();
                string model = carInfo.Split()[0];
                double fuelAmount = double.Parse(carInfo.Split()[1]);
                double fuelConsuptionFor1Km = double.Parse(carInfo.Split()[2]);

                Car car = new Car(model, fuelAmount, fuelConsuptionFor1Km);
                cars.Add(car);
            }

            string command = Console.ReadLine();
            while (command != "End")
            {
                if (command.StartsWith("Drive"))
                {
                    string carModel = command.Split()[1];
                    double amountOfKm = double.Parse(command.Split()[2]);

                    Car carToDrive = cars.First(car => car.Model == carModel);
                    carToDrive.Drive(amountOfKm);
                }
                
                command = Console.ReadLine();
            }
            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
            }
        }
    }
}
