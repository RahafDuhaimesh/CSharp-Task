using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2July2024_Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Car car1 = new Car();
            car1.Display();
            car1.DisplayInfo("Kia");
            car1.DisplayInfo("Kia", 1980);

          BMW car2 = new BMW();
            car2.Display();

        }
    }
}
