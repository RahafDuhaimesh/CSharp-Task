using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2July2024_Task1
{
    public  class Car
    {
        // Properties
        public string Make { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public int Model { get; set; }
        public int PalletNo { get; set; }
        public string Color { get; set; }

        // Methods 
        public virtual void Display()
        {
            Console.WriteLine("Welcome Car");
        }
        public void DisplayInfo(string make, int year)
        {
            Console.WriteLine($"The car is {make} made in year {year} .");
        }
        public void DisplayInfo(string make)
        {
            Console.WriteLine($"The car is {make} .");
        }

    }

    public  class BMW : Car
    {
        public override void Display()
        {
            Console.WriteLine("Welcome BMW");
        }
    }
}
