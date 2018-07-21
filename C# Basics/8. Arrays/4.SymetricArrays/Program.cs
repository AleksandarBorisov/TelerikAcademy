using System;

namespace _4.SymetricArrays
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool[] symetric = new bool[n];
            for (int i = 0; i < n; i++)
            {
                string[] currentArray = Console.ReadLine().Split(' ');
                symetric[i] = true;
                int leftIndex = 0;
                int rightIndex = currentArray.Length - 1;
                while (leftIndex<=rightIndex)
                {
                    if (currentArray[leftIndex] != currentArray[rightIndex])
                    {
                        symetric[i] = false;
                        break;
                    }
                    leftIndex++;
                    rightIndex--;
                }
            }
            foreach (var item in symetric)
            {
                Console.WriteLine(item == true ? "Yes" : "No");
            }
        }
    }
}
