using System;

namespace Drones
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            // Initialize the repository (Airfield)
            Airfield airfield = new Airfield("Heathrow", 10, 10.5);

            // Initialize entity
            Drone drone = new Drone("D20", "DEERC", 6);

            // Print Drone
            Console.WriteLine(drone);
            // Drone: D20
            // Manufactured by: DEERC
            // Range: 6 kilometers

            // Add Drone
            Console.WriteLine(airfield.AddDrone(drone));
            // Successfully added D20 to the airfield.
            Console.WriteLine(airfield.Count); // 1

        }
    }
}
