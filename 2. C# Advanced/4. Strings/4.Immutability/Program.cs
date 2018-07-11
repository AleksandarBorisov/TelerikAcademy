using System;

namespace _4.Immutability
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hello, Telerik Academy";
            Console.WriteLine(text[0]);
            string text1 = "Hello, Telerik Academy";
            string text2 = "Hello, Telerik Academy";
            Console.WriteLine(Object.ReferenceEquals(text1, text2));
            text2 += "!";
            Console.WriteLine(Object.ReferenceEquals(text1, text2));
        }
    }
}
