using System;

namespace MathPower
{
    class Program
    {
        static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            double power = double.Parse(Console.ReadLine());
            double numberRaisedToPower = CalculatePower(number, power);
            Console.WriteLine(numberRaisedToPower);
        }
        static double CalculatePower(double number, double power)
        {
            double result = 0d;
            result = Math.Pow(number, power);
            //for (int i = 0; i < power; i++)
            //{
            //    result *= number;//Работи по бавно от метода Math.Pow
            //}
            return result;
        }
    }
}
