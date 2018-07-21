using System;

namespace CompareArrays
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];
            int[] secondArray = new int[n];
            bool equal = true;
            for (int row = 0; row < n; row++)
            {
                firstArray[row] = int.Parse(Console.ReadLine());
            }
            for (int row = 0; row < n; row++)
            {
                secondArray[row] = int.Parse(Console.ReadLine());
                if (firstArray[row] != secondArray[row])
                {
                    equal = false;
                    break;
                }
            }
            Console.WriteLine(equal == true ? "Equal" : "Not equal");
        }
    }
}
