using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object helloWorld = hello + " " + world;
            string oHelloWorld = helloWorld.ToString();
            Console.WriteLine(oHelloWorld);
        }
    }
}
