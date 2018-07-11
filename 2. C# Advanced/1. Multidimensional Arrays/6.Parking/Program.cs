using System;

namespace _6.Parking
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            string[] line = Console.ReadLine().Split();
            int n = int.Parse(line[0]);
            int m = int.Parse(line[1]);
            char[,] map = new char[n, m];
            string coordX = "0011";
            string coordY = "0101";
            //byte[] coordX = new byte[] { 0, 0, 1, 1 };
            //byte[] coordY = new byte[] { 0, 1, 0, 1 };
            short[] parkedCars = new short[5];
            for (int i = 0; i < n; i++)
            {
                string row = Console.ReadLine();
                for (int j = 0; j < m; j++)
                {
                    map[i, j] = row[j];
                }
            }

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    int countOfParkedCars = 0;
                    bool skip = false;
                    for (int k = 0; k < coordX.Length; k++)
                    {
                        if (map[i + coordX[k] - '0', j + coordY[k] - '0'] == '#')
                        {
                            skip = true;
                            break;
                        }
                        else if (map[i + coordX[k] - '0', j + coordY[k] - '0'] == 'X')
                        {
                            countOfParkedCars++;
                        }
                    }
                    if (!skip)
                    {
                        parkedCars[countOfParkedCars]++;
                    }
                }
            }
            foreach (var parked in parkedCars)
            {
                Console.WriteLine(parked);
            }
        }
    }
}
