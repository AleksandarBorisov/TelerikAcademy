using System;

namespace GenerateRectangles
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            if (4 * n * n >= m)
            {
                for (int left = -n; left < n; left++)
                {
                    for (int top = -n; top < n; top++)
                    {
                        for (int right = left + 1; right <= n; right++)
                        {
                            for (int bottom = top + 1; bottom <= n; bottom++)
                            {
                                int area = Math.Abs(right - left) * Math.Abs(bottom - top);
                                if (area >= m)
                                {
                                    Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", left, top, right, bottom, area);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
