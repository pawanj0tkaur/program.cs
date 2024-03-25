using System;

// Base class representing a generic vehicle
public class Vehicle
{
    // Properties
    private string model;
    private string manufacturer;
    private int year;
    private double rentalPrice;

    public double RentalPrice { get; internal set; }

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

// Subclass representing a Car
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

// Subclass representing a Truck
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

// Subclass representing a Motorcycle
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

class Program
{
    static void Main(string[] args)
    {
        // Create instances of different vehicles
        Car car = new Car("Civic", "Honda", 2022, 50.0, 4);
        Truck truck = new Truck("F150", "Ford", 2020, 100.0, 5.0);
        Motorcycle motorcycle = new Motorcycle("Ninja", "Kawasaki", 2021, 30.0, "Sport");

        // Display details of each vehicle
        Console.WriteLine("Car Details:");
        car.DisplayDetails();
        Console.WriteLine();

        Console.WriteLine("Truck Details:");
        truck.DisplayDetails();
        Console.WriteLine();

        Console.WriteLine("Motorcycle Details:");
        motorcycle.DisplayDetails();
    }
}

