using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0x00FE;
            Console.WriteLine(a);
            char ch = '\u002A';
            Console.WriteLine(ch);
            bool isFemale = false;
            Console.WriteLine(isFemale);
            string hello = "Hello";
            string world = "world";
            object helloWorld = hello + " " + world;
            string final = helloWorld.ToString();
            Console.WriteLine(final);
        }
    }
}
