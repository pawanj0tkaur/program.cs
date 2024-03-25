using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.cs
{
    internal class Motorcycle
    {
        public class Motorcycle : Vehicle
        {
            private string type;

            public Motorcycle(string model, string manufacturer, int year, double rentalPrice, string type)
                : base(model, manufacturer, year, rentalPrice)
            {
                this.type = type;
            }

            public string GetType() => type;
            public void SetType(string type) => this.type = type;

            // Override DisplayDetails method to include motorcycle-specific details
            public override void DisplayDetails()
            {
                base.DisplayDetails();
                Console.WriteLine($"Type: {type}");
            }
        }
    }
}
