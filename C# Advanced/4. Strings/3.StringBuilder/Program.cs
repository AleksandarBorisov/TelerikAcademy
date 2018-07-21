using System;
using System.Text;//Използва се за StringBuilder
using System.Diagnostics;//Използва се за StopWatch-a

namespace _2.StringBuilderDemo
{
    class Program
    {
        static void Main()
        {
            int count = 100000;
            string newStr = "";
            StringBuilder sb = new StringBuilder();
            Stopwatch sw = Stopwatch.StartNew();

            for (int i = 0; i < count; i++)
            {
                newStr += i;
            }
            Console.WriteLine($"String concatenate: {sw.ElapsedMilliseconds}");
            sw.Restart();

            for (int i = 0; i < count; i++)
            {
                sb.Append(i);
            }

            Console.WriteLine($"StringBuilder Append: {sw.ElapsedMilliseconds}");
        }
    }
}
