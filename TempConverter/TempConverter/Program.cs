using System;

namespace TempConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            TempConverter test = new TempConverter();

            Console.WriteLine($"89 degrees fahrenheit is {TempConverter.FahrenheitToCelsius(89)} degrees celsius");
            Console.WriteLine($"89 degrees celsius is {TempConverter.CelsiusToFahrenheit(89)} degrees fahrenheit");

        }
    }
}
