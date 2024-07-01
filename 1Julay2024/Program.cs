using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1Julay2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Kia",2000,"Serato",4400,"vip",5599,"white");
            car1.Start();
            Console.WriteLine(car1.GetCarInfo()); 
            car1.Stop();
            Console.WriteLine("---------------------------------------");
            BMW car2 = new BMW("BMW", 2022, "SUV", 55000, "X5", 123456, "Black");
            car2.Start();
            Console.WriteLine(car2.GetCarInfo());
            car2.Stop();
        }
    }
}
