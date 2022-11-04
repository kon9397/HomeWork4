using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 47, b = 32;

            Console.WriteLine("Введите арифметический знак");

            string sign = Console.ReadLine();

            switch(sign)
            {
                case "+":
                    Console.WriteLine(a + b);
                    break;
                case "-":
                    Console.WriteLine(a - b);
                    break;
                case "*":
                    Console.WriteLine(a * b);
                    break;
                case "/":
                    if(b == 0)
                    {
                        Console.WriteLine("На 0 делить нельзя!");
                        break;
                    }
                    Console.WriteLine(a / b);
                    break;
                case "%":
                    if (b == 0)
                    {
                        Console.WriteLine("На 0 делить нельзя!");
                        break;
                    }
                    Console.WriteLine(a % b);
                    break;
                default:
                    Console.WriteLine("Не понятный знак. Попробуйте еще раз");
                    Console.WriteLine("Знаки для использования: + - * / %");
                    break;
            }

            Console.ReadKey();


        }
    }
}
