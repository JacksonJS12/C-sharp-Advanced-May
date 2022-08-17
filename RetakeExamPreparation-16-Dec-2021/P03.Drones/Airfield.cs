using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Drones
{
    public class Airfield
    {
        private ICollection<Drone> drones;
        public Airfield(string name, int capacity, double landingStrip)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.LandingStrip = landingStrip;

            this.drones = new List<Drone>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        public double LandingStrip  { get; set; }

        public int Count
            => drones.Count;

        public string AddDrone(Drone drone)
        {
            if (this.Capacity > drones.Count)
            {
                if (!string.IsNullOrEmpty(drone.Brand) &&
                    !string.IsNullOrEmpty(drone.Name) &&
                    drone.Range > 5 && drone.Range < 15)
                {
                    this.drones.Add(drone);
                    return $"Successfully added {drone.Name} to the airfield.";
                }
                return "Invalid drone.";
            }
            return "Airfield is full.";


        }

        public bool RemoveDrone(string name)
        {
            bool isThereDroneToRemove = false;
            Drone droneToRemove = this.drones.FirstOrDefault(d => d.Name == name);
            if (droneToRemove != null)
            {
                isThereDroneToRemove = true;
                this.drones.Remove(droneToRemove);
            }
            return isThereDroneToRemove;
        }

        public int RemoveDroneByBrand(string brand)
        {
            var dronesToRemove = this.drones.Where(d => d.Brand == brand).ToList();
            for (int i = 0; i < dronesToRemove.Count; i++)
            {
                this.drones.Remove(dronesToRemove[i]);
            }
            return dronesToRemove.Count;
        }

        public Drone FlyDrone(string name)
        {
           Drone drone = this.drones.FirstOrDefault(drone => drone.Name == name);
            if (drone != null)
            {
                drone.Available = false;
            }
            return drone;
        }

        public List<Drone> FlyDronesByRange(int range)
        { 
            var dronesInFlight = this.drones.Where(drone => drone.Range >= range).ToList();

            foreach (var drone in dronesInFlight)
            {
                drone.Available = false;
            }
            return dronesInFlight;
        }

        public string Report()
        {
            var sb = new StringBuilder();

            sb
                .AppendLine($"Drones available at {this.Name}:")
                .Append(string.Join
                (Environment.NewLine, 
                this.drones.Where(d => d.Available == true)));

            return sb.ToString();

        }
    }
}
