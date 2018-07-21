using System;


namespace Cinema
{
    class Program
    {
        static void Main()
        {
            string type = Console.ReadLine().ToLower();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            double income = 0;
            switch (type)
            {
                case "premiere": income = 12 * rows * columns; break;
                case "normal": income = 7.50 * rows * columns; break;
                case "discount": income = 5 * rows * columns; break;
            }
            Console.WriteLine($"{income:F2} leva");
            //Main();
        }
    }
}
