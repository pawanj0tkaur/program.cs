using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.cs
{
    internal class Car
    {
        public class Car : Vehicle
        {
            private int numberOfDoors;

            public Car(string model, string manufacturer, int year, double rentalPrice, int numberOfDoors)
                : base(model, manufacturer, year, rentalPrice)
            {
                this.numberOfDoors = numberOfDoors;
            }

            public int GetNumberOfDoors() => numberOfDoors;
            public void SetNumberOfDoors(int numberOfDoors) => this.numberOfDoors = numberOfDoors;

            // Override DisplayDetails method to include car-specific details
            public override void DisplayDetails()
            {
                base.DisplayDetails();
                Console.WriteLine($"Number of Doors: {numberOfDoors}");
            }
        }
    }
}
