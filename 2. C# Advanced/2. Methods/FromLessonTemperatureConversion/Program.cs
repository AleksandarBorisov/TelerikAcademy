using System;

namespace TemperatureConverter
{
    class Program
    {
        static double ConvertFromFahrenheitToCelsius(double temperatureF)
        {
            double temperatureC = (temperatureF - 32) * 5 / 9;
            return temperatureC;
        }

        static void Main()
        {
            Console.Write("Enter your body temperature in Fahrenheit degrees: ");
            double temperature = double.Parse(Console.ReadLine());
            temperature = ConvertFromFahrenheitToCelsius(temperature);
            Console.WriteLine("Your body temperature in Celsius degrees is {0}.", temperature);
            if (temperature >= 37)
            {
                Console.WriteLine("You are ill!");
            }
        }
    }
}
