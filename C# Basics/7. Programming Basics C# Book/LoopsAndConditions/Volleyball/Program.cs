using System;

namespace Volleyball
{
    class Program
    {
        static void Main()
        {
            string year = Console.ReadLine().ToLower();
            int holidays = int.Parse(Console.ReadLine());
            int home = int.Parse(Console.ReadLine());
            int totalGamesPlayed = 0;
            
            if (year == "leap")
            {
                totalGamesPlayed = (int)(1.15 * (home + 2 / 3.0 * holidays + 3 / 4.0 * (48 - home)));
            }
            else
            {
                totalGamesPlayed = (int)(home + 2 / 3.0 * holidays + 3 / 4.0 * (48 - home));
            }
            Console.WriteLine(totalGamesPlayed);
        }
    }
}
