using System;

namespace PrintASCIItable
{
    class Program
    {
        static void Main()
        {
            for(int i = 33; i <= 126; i++)
            {
                if (!char.IsWhiteSpace((char)i))
                Console.Write((char)i);
            }
        }
    }
}
