using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            if (userNumber >= 0 && userNumber <= 14)
            {
                Console.WriteLine("[0-14]");
            } 
            else if (userNumber >= 15 && userNumber <= 35) 
            {
                Console.WriteLine("[15-35]");
            }
            else if (userNumber >= 36 && userNumber <= 50)
            {
                Console.WriteLine("[36-50]");
            }
            else if (userNumber >= 51 && userNumber <= 100)
            {
                Console.WriteLine("[51-100]");
            }
            else
            {
                Console.WriteLine("Вашего числа нет в промежутках");
            }

            Console.ReadLine();
        }
    }
}
