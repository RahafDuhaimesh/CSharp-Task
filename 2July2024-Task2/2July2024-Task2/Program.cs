using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2July2024_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Dog dog = new Dog("Hasky");
            dog.MakeSound();
            dog.Sleep();
            dog.Eat();
            Console.WriteLine("---------------------------------");
            Cat cat = new Cat("Baldy");
            cat.MakeSound();
            cat.Sleep();
            cat.Eat();
            Console.WriteLine("---------------------------------");

        }
    }
}
