using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Task1
{
    internal class Car : Transport
    {
        public string Color { get; set; }
        public int NumSeats { get; set; }
        public FuelType FuelType { get; set; }

        public Car(string brand, string model, short year, string color, FuelType fuelType)
        {
            Brand = brand;
            Model = model;
            Year = year;
            Color = color;
            FuelType = fuelType;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Color: {Color}");
            Console.WriteLine($"Fuel type: {FuelType}");
        }
    }
}
