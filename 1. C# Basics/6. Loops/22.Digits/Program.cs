using System;
using System.Text;

namespace _22.Digits
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            string[] line = Console.ReadLine().Split();
            StringBuilder sb = new StringBuilder();
            int a = int.Parse(line[0]);
            int b = int.Parse(line[1]);
            int p1 = int.Parse(line[2]);
            int p2 = int.Parse(line[3]);
            int count = 0;
            for (int i = a; i <= b; i++)
            {
                sb.Append(i);
            }
            string numbers = sb.ToString();
            foreach (char digit in numbers)
            {
                if ((digit - '0') % p1 != 0 && (digit - '0') % p2 != 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
