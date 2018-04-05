using System;

namespace Stop
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int dots = n + 1;
            int lineTop = 2 * n + 1;
            int lineMid = lineTop - 2;
            Console.WriteLine("{0}{1}{0}",
                new string('.', dots),
                new string('_', lineTop));
            dots--;
            for (int top = 0; top < n; top++)
            {

                Console.WriteLine("{0}//{1}\\\\{0}",
                    new string('.', dots),
                    new string('_', lineMid));
                lineMid += 2;
                dots--;
            }
            Console.WriteLine("//{0}STOP!{0}\\\\",
                new string('_', (lineMid - 5) / 2));
            for (int bottom = 0; bottom < n; bottom++)
            {
                Console.WriteLine("{0}\\\\{1}//{0}",
                    new string('.', bottom),
                    new string('_', lineMid));
                lineMid -= 2;
            }
        }
    }
}
