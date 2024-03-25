using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.cs
{
    internal class Truck
    {
        public class Truck : Vehicle
        {
            private double cargoCapacity;

            public Truck(string model, string manufacturer, int year, double rentalPrice, double cargoCapacity)
                : base(model, manufacturer, year, rentalPrice)
            {
                this.cargoCapacity = cargoCapacity;
            }

            public double GetCargoCapacity() => cargoCapacity;
            public void SetCargoCapacity(double cargoCapacity) => this.cargoCapacity = cargoCapacity;

            // Override DisplayDetails method to include truck-specific details
            public override void DisplayDetails()
            {
                base.DisplayDetails();
                Console.WriteLine($"Cargo Capacity: {cargoCapacity} tons");
            }
        }

    }
}
