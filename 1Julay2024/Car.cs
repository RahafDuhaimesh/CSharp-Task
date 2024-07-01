using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _1Julay2024
{
    public class Car
    {
        // fields
        public string Make;
        public int Year;
        public string Type;
        public double Price;
        public string Model;
        public int PalletNo;
        public string Color;

        // Constructor
        public Car()
        {
            
        }
        public Car(string make, int year , string type, double price, string model, int palletNo, string color)
        {
            this.Make = make;
            this.Year = year;
            this.Type = type;
            this.Price = price;
            this.Model = model;
            this.PalletNo = palletNo;
            this.Color = color;

        }

        //Methods 
        public void Start()
        {
            Console.WriteLine($"The engine of {Make} {Year} starts to running.");
        }
        public void Stop()
        {
            Console.WriteLine($"The engine of {Make} {Year} ends running.");
        }
        public string GetCarInfo()
        {
            return $"Make: {Make}, Year: {Year}, Type: {Type}, Price: {Price}, Model: {Model}, Pallet No: {PalletNo}, Color: {Color}";
        }

    }
    public class BMW:Car
    {
        public BMW(string make, int year, string type, double price, string model, int palletNo, string color)
        {
            this.Make = make;
            this.Year = year;
            this.Type = type;
            this.Price = price;
            this.Model = model;
            this.PalletNo = palletNo;
            this.Color = color;
        }


    }

}
