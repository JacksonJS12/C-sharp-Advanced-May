using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private double fuelAmount;
        private double fuelConsumptionPerKilometer;
        private double travelledDistance;

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.TravelledDistance = 0;
        }

        public void Drive(double amountOfKm)
        {
            double neededLitters = amountOfKm * this.FuelConsumptionPerKilometer; 
            if (neededLitters <= FuelAmount)
            {
                this.FuelAmount -= neededLitters;
                this.TravelledDistance += amountOfKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}
