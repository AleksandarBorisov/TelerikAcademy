using System;
using System.Linq;

namespace _15._3DSlices
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            byte w = byte.Parse(input[0]);
            byte h = byte.Parse(input[1]);
            byte d = byte.Parse(input[2]);
            int[] sumsByFrontWall = new int[w];
            int[] sumsBySideWall = new int[h];
            int[] sumsByFloors = new int[d];
            int count = 0;

            for (int height = 0; height < h; height++)
            {
                input = Console.ReadLine().Split('|');
                for (int depth = 0; depth < input.Length; depth++)
                {
                    string[] currentArray = input[depth].Trim().Split();
                    for (int width = 0; width < currentArray.Length; width++)
                    {
                        int currentNumber = int.Parse(currentArray[width]);
                        sumsBySideWall[height] += currentNumber;
                        sumsByFrontWall[width] += currentNumber;
                        sumsByFloors[depth] += currentNumber;
                    }
                }
            }
            int cubeSum = sumsByFloors.Sum();
            int currentSum = 0;
            for (int i = 0; i < sumsByFloors.Length - 1; i++)
            {
                currentSum += sumsByFloors[i];
                if (currentSum == cubeSum / 2)
                {
                    count++;
                }
            }
            currentSum = 0;
            for (int i = 0; i < sumsByFrontWall.Length - 1; i++)
            {
                currentSum += sumsByFrontWall[i];
                if (currentSum == cubeSum / 2)
                {
                    count++;
                }
            }
            currentSum = 0;
            for (int i = 0; i < sumsBySideWall.Length - 1; i++)
            {
                currentSum += sumsBySideWall[i];
                if (currentSum == cubeSum / 2)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
