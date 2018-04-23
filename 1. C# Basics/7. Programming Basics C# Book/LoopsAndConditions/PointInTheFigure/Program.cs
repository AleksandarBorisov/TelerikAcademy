using System;

namespace PointInTheFigure
{
    class Program
    {
        static void Main()
        {
            int h = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());
            //Inside 
            bool insideRecOne = (x > 0 && x < 3 * h && y > 0 && y < h);
            bool insideRecTwo = (x > h && x < 2 * h && y >= h && y < 4 * h);
            //Outside
            bool outsideRecOne = (x < 0 || x > 3 * h ||y < 0 || y > h);
            bool outsideRecTwo = (x < h || x > 2 * h || y < h || y > 4 * h);
            if (insideRecOne || insideRecTwo)
            {
                Console.WriteLine("inside");
            }
            else if (outsideRecOne && outsideRecTwo)
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("border");
            }
            //Main();
        }
    }
}
