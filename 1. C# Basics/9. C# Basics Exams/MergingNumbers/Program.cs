using System;

namespace MergingNumbers
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            for (int merge = 0; merge < n - 1; merge++)
            {
                Console.Write("{0}{1} ", nums[merge] % 10, nums[merge + 1] / 10);
            }
            Console.WriteLine();
            for (int sum = 0; sum < n - 1; sum++)
            {
                Console.Write(nums[sum] + nums[sum + 1] + " ");
            }
            Console.WriteLine();
        }
    }
}
