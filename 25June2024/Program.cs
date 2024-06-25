using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25June2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------Task 1------------");
            Console.WriteLine("Please enter a string :");
            string x = Console.ReadLine();
            Console.WriteLine("The string you entered is  : " + x);

            Console.WriteLine("------------Task 2------------");
            Double firstVar = 4.122;
            Console.WriteLine("Example on double value : " + firstVar);

            string secondVar = "RAHAF";
            Console.WriteLine("Example on string value : " + secondVar);

            Char thirdVar = 'R';
            Console.WriteLine("Example on Char value : " + thirdVar);

            bool fourthVar = 5 > 6;
            Console.WriteLine("Example on bool value : " + fourthVar);

            int fifthVar = 4;
            Console.WriteLine("Example on int value : " + fifthVar);

            const int sixthVar = 4;
            Console.WriteLine("Example on const value : " + sixthVar);

            Console.WriteLine("------------Task 3------------");
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars[0]);
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars[2]);
            Console.WriteLine(cars[3]);
            Console.WriteLine("The array length : " + cars.Length);

            Console.WriteLine("------------Task 4------------");
            var info = new string[3];
            Console.Write("Input your first name : ");
            info[0] = Console.ReadLine();
            Console.Write("\nInput your last name : ");
            info[1] = Console.ReadLine();
            Console.Write("\nInput your year of birth : ");
            info[2] = Console.ReadLine();
            Console.WriteLine("Your first name is " + info[0] + " ,your last name is " + info[1] + " ,your year of birth is " + info[2]);

            Console.WriteLine("------------Task 5------------");
            string[] numbers = { "1", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            Console.WriteLine("Elements in array are: " + string.Join(" ", numbers));

            Console.WriteLine("------------Task 6------------");
            int[] summation = { 2, 5, 8 };
            int sumValue = summation[0] + summation[1] + summation[2];
            Console.WriteLine("Sum of all elements stored in the array is : " + sumValue);




        }
    }
}
