using System;

namespace Permutations
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int k = 0; k < n; k++)
            {
                a[k] = k + 1;
            }
            Console.WriteLine(String.Join(" ", a));
            while (a.Length > 1)
            {//Ако имаме само един елемент, въобще няма да влезнем в масива
                int i = a.Length - 1;
                while (i > 0 && a[i - 1] >= a[i])
                {
                    i--;
                    if (i == 0)
                    {
                        return;
                    }
                }
                int j = a.Length - 1;
                while (a[i - 1] > a[j])
                {
                    j--;
                }
                int swap = a[i - 1];
                a[i - 1] = a[j];
                a[j] = swap;
                j = a.Length - 1;
                while (i < j)
                {
                    swap = a[i];
                    a[i] = a[j];
                    a[j] = swap;
                    i++;
                    j--;
                }
                Console.WriteLine(String.Join(" ", a));
            }
        }
    }
}
