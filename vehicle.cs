using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.cs
{
    internal class vehicle
    {
        public class Vehicle
        {
            // Properties
            private string model;
            private string manufacturer;
            private int year;
            private double rentalPrice;

            // Constructor
            public Vehicle(string model, string manufacturer, int year, double rentalPrice)
            {
                this.model = model;
                this.manufacturer = manufacturer;
                this.year = year;
                this.rentalPrice = rentalPrice;
            }

            // Methods to get and set vehicle properties
            public string GetModel() => model;
            public string GetManufacturer() => manufacturer;
            public int GetYear() => year;
            public double GetRentalPrice() => rentalPrice;

            public void SetModel(string model) => this.model = model;
            public void SetManufacturer(string manufacturer) => this.manufacturer = manufacturer;
            public void SetYear(int year) => this.year = year;
            public void SetRentalPrice(double rentalPrice) => this.rentalPrice = rentalPrice;

            // Display vehicle details
            public virtual void DisplayDetails()
            {
                Console.WriteLine($"Model: {model}");
                Console.WriteLine($"Manufacturer: {manufacturer}");
                Console.WriteLine($"Year: {year}");
                Console.WriteLine($"Rental Price: ${rentalPrice}");
            }
        }
    }
}
