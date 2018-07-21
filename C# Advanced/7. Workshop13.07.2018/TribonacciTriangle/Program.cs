using System;
using System.Text;

namespace TribonacciTriangle
{
    class Program
    {
        static void Main()
        {
            long f1 = int.Parse(Console.ReadLine());
            long f2 = int.Parse(Console.ReadLine());
            long f3 = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            Console.WriteLine(sb.Append(f1));
            sb.Clear();
            Console.WriteLine(sb.Append(f2).Append(" ").Append(f3));
            for (int i = 3; i <= l; i++)
            {
                sb.Clear();
                for (int j = 0; j < i; j++)
                {
                    long f4 = f1 + f2 + f3;
                    f1 = f2;
                    f2 = f3;
                    f3 = f4;
                    sb.Append(f4).Append(" ");
                }
                sb.Remove(sb.Length - 1, 1);
                Console.WriteLine(sb);
            }
        }
    }
}
