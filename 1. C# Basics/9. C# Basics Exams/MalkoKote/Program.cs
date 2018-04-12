using System;

namespace MalkoKote
{
    class Program
    {
        static void Main()
        {
            int sizeOfKote = int.Parse(Console.ReadLine());
            char signOfKote = char.Parse(Console.ReadLine());
            int spacesBetweenYears = sizeOfKote / 4 - 1;
            //Draw ears
            Console.WriteLine(" {0}{1}{0} ", signOfKote, new string(' ', spacesBetweenYears));
            //Draw head
            for (int i = 0; i < spacesBetweenYears; i++)
            {
                Console.WriteLine(" {0} ", new string(signOfKote, spacesBetweenYears + 2));
            }
            //Draw neck
            for (int i = 0; i < spacesBetweenYears; i++)
            {
                Console.WriteLine("  {0}  ", new string(signOfKote, spacesBetweenYears));
            }
            //Draw upperBody + upperTail
            for (int i = 0; i <= spacesBetweenYears; i++)
            {
                Console.Write(" {0} ", new string(signOfKote, spacesBetweenYears + 2));
                if (i == spacesBetweenYears)
                {
                    Console.WriteLine("  {0}", new string(signOfKote, spacesBetweenYears + 1));
                }
                else
                {
                    Console.WriteLine();
                }
            }
            //Draw lowerBody + lowerTail
            for (int i = 1; i <= sizeOfKote / 4 + 1; i++)
            {
                Console.Write(new string(signOfKote, sizeOfKote / 4 + 3));
                if (i == sizeOfKote / 4 + 1)
                {
                    Console.WriteLine(" {0}{0}", signOfKote);
                }
                else
                {
                    Console.WriteLine("  {0}", signOfKote);
                }
            }
            //Draw legs
            Console.WriteLine(" {0}", new string(signOfKote, sizeOfKote / 4 + 4));
        }
    }
}
