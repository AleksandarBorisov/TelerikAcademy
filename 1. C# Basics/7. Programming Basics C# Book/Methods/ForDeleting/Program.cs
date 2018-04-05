using System;

namespace ForDeleting
{
    class Program
    {

        static void PrintHello(string text, int repeat)
        {
            for (int i = 0; i < repeat; i++)
            {
                Console.WriteLine(text);
            }
        }

        static void Main()
        {

            PrintHello("Hello", 10);
            PrintHello("Te tva e bace", 5);
            //double first = 1.22;
            //double second =3.27;
            //double Result (double a, double b)
            //{
            //    return a + b;
            //}
            //Console.WriteLine(Result(first, second));
            //string output = "I am a local function";
            //void PrintOutPut()
            //{
            //    Console.WriteLine(output);
            //}
            //PrintOutPut();
        }
    }
}
