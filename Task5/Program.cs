using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string weatherDesc = Console.ReadLine();

            switch (weatherDesc.ToLower())
            {
                case "жаркая":
                    Console.WriteLine("hot");
                    break;
                case "холодная":
                    Console.WriteLine("cold");
                    break;
                case "ветренная":
                    Console.WriteLine("windy");
                    break;
                case "дождливая":
                    Console.WriteLine("rainy");
                    break;
                case "облачная":
                    Console.WriteLine("cloudy");
                    break;
                case "великолепная":
                    Console.WriteLine("great");
                    break;
                case "изменчивая":
                    Console.WriteLine("changeable");
                    break;
                case "морозная":
                    Console.WriteLine("frosty");
                    break;
                case "свежая":
                    Console.WriteLine("fresh");
                    break;
                case "солнечная":
                    Console.WriteLine("sunny");
                    break;
                default:
                    Console.WriteLine("Нет такого слова, попробуйте еще раз!");
                    break;
            }

            Console.ReadLine();
        }
    }
}
