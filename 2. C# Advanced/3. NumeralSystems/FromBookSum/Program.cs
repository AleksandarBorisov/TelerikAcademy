using System;

namespace FromBookSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //float sum = 0f;
            //double sum = 0;
            decimal sum = 0M;
            for (int i = 0; i < 50000000; i++)
            {
                sum += 0.000001m;//f
            }
            Console.WriteLine("{0:G}",sum);
        }
    }
}
