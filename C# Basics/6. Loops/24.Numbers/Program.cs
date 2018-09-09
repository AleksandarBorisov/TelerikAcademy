using System;
using System.Linq;

namespace _24.Numbers
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int a = -1000;
            int b = -1000;
            int aSqrB = 0;
            int bSqrA = 0;
            string result = "";
            do
            {
                b = -1000;
                do
                {
                    aSqrB = a * a * b;
                    bSqrA = b * b * a;
                    if ((numbers[0] == 0 || numbers[0] == a) &&
                        (numbers[1] == 0 || numbers[1] == b) &&
                        (numbers[2] == 0 || numbers[2] == aSqrB) &&
                        (numbers[3] == 0 || numbers[3] == bSqrA))
                    {
                        result = a.ToString() + " " + b.ToString() + " " + aSqrB.ToString() + " " + bSqrA.ToString();
                        Console.WriteLine(result);
                        return;
                    }
                    b++;
                }
                while (b <= a);
                a++;
            }
            while (a <= 1000);
        }
    }
}
