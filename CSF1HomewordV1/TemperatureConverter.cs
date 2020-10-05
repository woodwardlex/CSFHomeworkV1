using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSF1HomewordV1
{
    class TemperatureConverter
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            do
            {
                Console.WriteLine("Fahrenheit/Calcuis Calculator");

                Console.Write("Which temperature are you converting from?\nF) Fahrenheit\nC) Celcius\nX) Exit");
                string userInput = Console.ReadLine().ToUpper();

                Console.Clear();

                switch (userInput)
                {
                    case "F":
                    case "FAHRENHEIT":
                        Console.Write("What is the temperature in Fahrenheit? ");
                        double fahrenheit1 = double.Parse(Console.ReadLine());
                        double celcius1 = ((fahrenheit1 - 32) / (9.0 / 5.0));
                        Console.WriteLine($"The temperature {fahrenheit1} degrees fahrenheit is {celcius1} degrees in Celcius.");
                        break;
                    case "C":
                    case "CELCIUS":
                        Console.WriteLine("What is the temperature in Celcius? ");
                        double celcius2 = double.Parse(Console.ReadLine());
                        double fahrenheit2 = (celcius2 * (9.0 / 5.0) + 32);
                        Console.WriteLine($"The temperature {celcius2} degrees celcius is {fahrenheit2} degrees fahrenheit.");
                        break;
                    case "X":
                    case "EXIT":
                        Console.WriteLine("Come again!");
                        repeat = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Try again.");
                        break;
                }
            } while (repeat);
        }
    }
}
