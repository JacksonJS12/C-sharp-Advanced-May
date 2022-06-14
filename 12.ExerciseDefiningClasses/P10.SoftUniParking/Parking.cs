using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftUniParking
{
    internal class Parking
    {
        private List<Car> cars;
        private int capacity;
        private int count;

        public List<Car> Cars
        {
            get { return cars; }
            set { cars = value; }
        }
        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }
        public Parking(int capacity)
        {
            this.Cars = new List<Car>();
            this.Capacity = capacity;
        }


        public string AddCar(Car addedCar)
        {
            bool canAddCar = true;
            foreach (Car car in cars)
            {
                if (car.RegistrationNumber == addedCar.RegistrationNumber)
                {
                    canAddCar = false;
                    return "Car with that registration number, already exists!";
                }
            }

            if (cars.Count + 1 > this.Capacity)
            {
                canAddCar = false;
                return "Parking is full!";
            }

            if (canAddCar)
            {
                Cars.Add(addedCar);
                return $"Successfully added new car {addedCar.Make} {addedCar.RegistrationNumber}";
            }
            return string.Empty;
        }

        public string RemoveCar(string registrationNumber)
        {
            bool isAvailable = false;
            foreach (Car car in cars)
            {
                if (car.RegistrationNumber == registrationNumber)
                {
                    isAvailable = true;
                }
            }

            if (!isAvailable)
            {
                return "Car with that registration number, doesn't exist!";
            }
            else
            {
                Car carToRemove = this.Cars.First(car => car.RegistrationNumber == registrationNumber);
                this.Cars.Remove(carToRemove);
                return $"Successfully removed {registrationNumber}";

            }
        }

        public Car GetCar(string registrationNumber)
        {
            return this.Cars.First(car => car.RegistrationNumber == registrationNumber);
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (string registrationNumber in registrationNumbers)
            {
                RemoveCar(registrationNumber);
            }
        }
    }
}