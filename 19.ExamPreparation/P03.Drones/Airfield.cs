using System.Collections.Generic;
using System.Linq;
using System;

namespace Drones
{
    public class Airfield
    {
        public List<Drone> Drones { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public double LandingStrip { get; set; }

        public Airfield( string name, int capacity, double landingStrip)
        {
            this.Name = name;
            this.Capacity = capacity;
            this.LandingStrip = landingStrip;
            this.Drones = new List<Drone>();
        }
        public int Count => this.Drones.Count(drone => drone.Avaiable == true);
        public string AddDrone(Drone drone)
        {
            if (string.IsNullOrEmpty(drone.Name) || 
                string.IsNullOrEmpty(drone.Brand) ||
                drone.Range <= 5 ||
                drone.Range >= 15)
            {
                return "Invalid drone.";
            }

            if (this.Drones.Count >= this.Capacity)
            {
                return "Airfield is full.";
            }

            this.Drones.Add(drone);
            return $"Successfully added {drone.Name} to the airfield.";
        }
        public bool RemoveDrone(string name)
        {
            int count = this.Drones.RemoveAll(drone => drone.Name == name);
            return count > 0;
            //bool found = false;
            //var newDrone = new List<Drone>();
            //foreach (var drone in this.Drones)
            //{
            //    if(drone.Name != name)
            //        found = true;
            //        newDrone.Add(drone);
                
            //}
            //this.Drones = newDrone;
            //return found;
        }
        public int RemoveDroneByBrand(string brand)
        {
            int count = this.Drones.RemoveAll(drone => drone.Brand == brand);
            return count;
        }
        public Drone FlyDrone(string name)
        {
            Drone drone = this.Drones.FirstOrDefault(d => d.Name == name);
            if (drone == null)
            {
                return null;
            }
            drone.Avaiable = false;
            return drone;
        }
        public List<Drone> FlyDronesByRange(int range)
        {
            List<Drone> drones = this.Drones.Where(drone => drone.Range == range).ToList();
            foreach (var drone in drones)
            {
                drone.Avaiable = false;
            }
            return drones;
        }
        public string Report()
        {
            var dronesNames = this.Drones.Where(drones => drones.Avaiable == true).ToList();
            return
                $"Drones available at {this.Name}:" +
                Environment.NewLine +
                $"{string.Join(Environment.NewLine, dronesNames)}";

        }
    }
}
