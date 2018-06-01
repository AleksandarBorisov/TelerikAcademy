using System;

namespace GoingToAParty
{
    class Program
    {
        static void Main()
        {
            string directions = Console.ReadLine();
            int position = 0;
            string message = "Djor and Djano are lost at {0}!";
            while (position >= 0 && position < directions.Length)
            {
                if (directions[position] == '^')
                {
                    message = "Djor and Djano are at the party at {0}!";
                    break;
                }
                else if ('a' <= directions[position] && directions[position] <= 'z')
                {
                    position += (directions[position] - 'a') + 1;
                }
                else if ('A' <= directions[position] && directions[position] <= 'Z')
                {
                    position -= (directions[position] - 'A') + 1;
                }
            }
            Console.WriteLine(message, position);
        }
    }
}
