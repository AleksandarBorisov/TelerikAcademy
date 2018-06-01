using System;

namespace _6.Hotels
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] line = Console.ReadLine().Split(' ');
            int[] hotels = new int[line.Length];
            for (int i = 0; i < n; i++)
            {
                hotels[i] = int.Parse(line[i]);
            }
            int maxHeight = hotels[0];
            int hotelsSeen = 1;
            for (int i = 1; i < n; i++)
            {
                if (hotels[i] > maxHeight)
                {
                    maxHeight = hotels[i];
                    hotelsSeen++;
                }
            }
            Console.Write(hotelsSeen + " ");
            maxHeight = hotels[n - 1];
            hotelsSeen = 1;
            for (int i = n - 2; i >= 0; i--)
            {
                if (hotels[i] > maxHeight)
                {
                    maxHeight = hotels[i];
                    hotelsSeen++;
                }
            }
            Console.WriteLine(hotelsSeen);
        }
    }
}
