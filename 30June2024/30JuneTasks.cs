using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _30June2024
{
    public class _30JuneTasks
    {
        // ------------------ Task 1 -----------------------
        public class SumAndAvg
        {
            public void Summation()
            {
                Console.WriteLine("Please enter 10 numbers : ");
                int sum = 0;
                int[] ints = new int[10];
                foreach (int i in ints)
                {
                    ints[i] = Convert.ToInt32(Console.ReadLine());
                    sum += ints[i];
                }
                double Avg = (double)sum / 10;
                Console.WriteLine($"The summation of numbers  equals to {sum} and the average equals {Avg}");

            }
        }

        // ------------------ Task 2 -----------------------
        public class Cubic
        {
            public int Term;

            public void ReturnCubic()
            {
                Console.Write("Please enter the term that you want to make cubics until it : ");
                Term = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i <= Term; i++)
                {
                    Console.WriteLine($"The cubic of {i} = {i * i * i}");
                }
            }


        }

        // ------------------ Task 3 -----------------------
        public class Task3
        {
            public static int[] GetYears(int[] years)
            {
                int[] greaterYears = new int[years.Length];

                for (int i = 0; i < years.Length; i++)
                {
                    if (years[i] >= 1950)
                    {
                        greaterYears[i] = years[i];
                    }
                }

                return greaterYears;
            }
        }

        // ------------------ Task 4 -----------------------
        public class Age
        {
            public static int days;

            public static int Days(int age)
            {
                days = age * 365;
                return days;
            }

        }


        // ------------------ Task 5 -----------------------
        public class PersonData
        {
            public string Name;
            public string Email;
            public int ID;
            public string Gender;
            public string Phone;
            public int Age;


            public PersonData()
            {
                this.Name = "Rahaf";
                this.Email = "Rahafduhaimesh211@gmail.com";
                this.ID = 2000200752;
                this.Gender = "Female";
                this.Phone = "0795142355";
                this.Age = 23;
            }

            public PersonData(string name, string email, int Id, string gender, string phone, int age)
            {
                this.Name = name;
                this.Email = email;
                this.Gender = gender;
                this.ID = Id;
                if (age >= 18 && age <= 60)
                {
                    this.Age = age;
                }
                if (Regex.IsMatch(phone, @"^(077|078|079)\d{7}$"))
                {

                    this.Phone = phone;
                }
                

            }
            public void DisplayData()
            {
                Console.WriteLine($"Your name is : {Name}");
                Console.WriteLine($"Your email is : {Email}");
                Console.WriteLine($"Your ID is : {ID}");
                Console.WriteLine($"Your gender is : {Gender}");
                Console.WriteLine($"Your phone is : {Phone}");
                Console.WriteLine($"Your age is : {Age}");

            }
        }
    }




}

