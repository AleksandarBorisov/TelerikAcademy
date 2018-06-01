using System;

namespace _15.Flasks
{
    class Program
    {
        static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');
            long quantity = long.Parse(line[1]);
            int flaskNumber = 0;
            long flaskSize = 0;
            while (flaskSize < quantity)
            {
                flaskSize = flaskNumber + flaskSize;
                flaskNumber++;
            }
            Console.WriteLine(flaskNumber % 2 == 0 ? ++flaskNumber : flaskNumber);
        }
    }
}
