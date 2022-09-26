using System;
namespace StaticExercise
{
    public class TempConverter
    {
        public TempConverter()
        {
        }

        public static double FahrenheitToCelsius(double number)
        {
            return 5 / 9 * (number - 32);
        }

        public static double CelsiusToFahrenheit(double number)
        {
            return (number * 9 / 5) + 32;
        }
    }
}

