using System;
using System.Diagnostics;
using System.Text;

namespace ReverseString
{
    class Program
    {
        static void Main()
        {
            string message = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            Stopwatch sw = Stopwatch.StartNew();
            string result = "";
            for (int i = message.Length-1; i >= 0; i--)
            {
                if (char.IsLetter(message[i]))
                {
                    result += message[i];
                }
            }
            Console.WriteLine(result);
            Console.WriteLine($"String concatenate: {sw.ElapsedMilliseconds}");
            sw.Restart();
            for (int i = message.Length - 1; i >= 0; i--)
            {
                sb.Append(message[i]);
            }
            Console.WriteLine(sb.ToString());
            Console.WriteLine($"StringBuilder append: {sw.ElapsedMilliseconds}");
        }
    }
}
