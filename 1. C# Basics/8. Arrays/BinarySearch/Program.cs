using System;

class Sample
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        int downLimit = 0;
        int upLimit = n - 1;
        int answer = -1;
        int mid = 0;
        int index = downLimit + upLimit;
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }
        int x = int.Parse(Console.ReadLine());
        while (downLimit <= upLimit)
        {
            mid = (downLimit + upLimit) / 2;
            if (numbers[mid] < x)
            {
                downLimit = mid + 1;
            }
            else if (numbers[mid] > x)
            {
                upLimit = mid - 1;
            }
            else
            {
                answer = mid;//Самият алгоритъм винаги намира първия елемент ако са няколко
                break;
            }
        }
        Console.WriteLine(answer);
    }
}
