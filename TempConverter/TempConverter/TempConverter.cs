using System;
namespace TempConverter
{
    public class TempConverter
    {
        public TempConverter()
        {
        }
        public static double CelsiusToFahrenheit(double input)
        {
            return (input * 9 / 5) + 32;
        }
        public static double FahrenheitToCelsius(double input)
        {
            return (input - 32) * 5 / 9;
        }

    }
}
