using System;

namespace ReadingFromFile
{
    class Program
    {
        static void Main()
        {
            //int r = Console.Read();
            //while (r != -1)
            //{
            //Console.Write((char)r);
            //r = Console.Read();
            //}
            string str = Console.ReadLine();
            while (str != null)
            {
                Console.WriteLine(str);
                str = Console.ReadLine();
            }
        }
    }
}
