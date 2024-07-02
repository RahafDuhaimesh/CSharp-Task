using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2July2024_Task2
{
    public interface ISound
    {
        void MakeSound();
    }
    public abstract class Animal
    {   // Property
        public string Name { get; set; }

        // Constructor 
        public Animal(string name)
        {
            this.Name = name;
        }
        public Animal()
        {
            
        }

        // Abstract Method
        public abstract  void Eat();

        // Concrete Method 
        public void Sleep()
        {
            Console.WriteLine($"{Name} is sleeping.");

        }

    }
    public class Dog:Animal ,ISound
    {
        public void MakeSound()
        {
            Console.WriteLine($"The sound of dog is : \"Woof!\" .");
        }
        public override void Eat()
        {
            Console.WriteLine("The dog eats meat");
        }
        public Dog(string name) : base(name)
        {
        }


    }
    public class Cat : Animal, ISound
    {
        public void MakeSound()
        {
            Console.WriteLine($"The sound of cat is : \"Meow!\" .");
        }
        public override void Eat()
        {
            Console.WriteLine("The cat eats meat");
        }
        public Cat(string name) : base(name)
        {
        }
    }
}
