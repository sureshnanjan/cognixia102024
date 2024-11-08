using System;

namespace TypeSystemDemo
{
    public enum VehicleType
    {
        Car,
        Truck,
        Motorcycle,
        Bicycle,
        Boat
    }

    public enum FuelType
    {
        Gasoline,
        Diesel,
        Electric,
        Hybrid,
        None
    }

    public class Vehicle
    {
        public VehicleType Type { get; set; }
        public FuelType Fuel { get; set; }

        public Vehicle(VehicleType type, FuelType fuel)
        {
            Type = type;
            Fuel = fuel;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"This is a {Type} that runs on {Fuel}.");
        }
    }
}