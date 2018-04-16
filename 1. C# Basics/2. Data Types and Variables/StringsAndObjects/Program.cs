using System;

namespace StringsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object helloWorld = hello + " " + world;
            string final = helloWorld.ToString();
            Console.WriteLine(final);
        }
    }
}
