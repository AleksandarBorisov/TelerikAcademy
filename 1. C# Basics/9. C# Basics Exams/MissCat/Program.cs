using System;

namespace MissCat
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] votes = new int[11];
            for (int i = 0; i < n; i++)
            {
                int vote = int.Parse(Console.ReadLine());
                votes[vote]++;
            }
            int winVotes = 0;
            int winner = 0;
            for (int i = 0; i <= 10; i++)
            {
                if (votes[i] > winVotes)
                {
                    winVotes = votes[i];
                    winner = i; 
                }
            }
            Console.WriteLine(winner);
            //Main();
        }
    }
}
