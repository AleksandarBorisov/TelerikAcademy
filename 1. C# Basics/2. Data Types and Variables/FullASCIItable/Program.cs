using System;

namespace PrintASCIItable
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i <= 127; i++)
            {
                if (!char.IsWhiteSpace((char)i))
                {
                    Console.Write((char)i + " ");
                }  
            }
        }
    }
}

