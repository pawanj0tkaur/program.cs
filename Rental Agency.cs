using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.cs
{
    internal class Rental_Agency
    {
        public class RentalAgency
        {
            // Properties
            private List<Vehicle> Fleet { get; set; }
            public double TotalRevenue { get; private set; }

            // Constructor
            public RentalAgency()
            {
                Fleet = new List<Vehicle>();
                TotalRevenue = 0;
            }

            // Method to add vehicles to the fleet
            public void AddVehicle(Vehicle vehicle)
            {
                Fleet.Add(vehicle);
            }

            // Method to remove vehicles from the fleet
            public void RemoveVehicle(Vehicle vehicle)
            {
                Fleet.Remove(vehicle);
            }

            // Method to rent a vehicle
            public void RentVehicle(Vehicle vehicle)
            {
                if (Fleet.Contains(vehicle))
                {
                    Fleet.Remove(vehicle); // Remove the rented vehicle from the fleet
                    TotalRevenue += vehicle.RentalPrice; // Add rental price to total revenue
                }
                else
                {
                    Console.WriteLine("Vehicle not available for rent.");
                }
            }
        }
    }
}
