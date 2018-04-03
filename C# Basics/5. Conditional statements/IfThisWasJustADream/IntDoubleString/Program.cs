using System;

namespace IntDoubleString
{
    class Program
    {
        static void Main()
        {
            string dataType = Console.ReadLine();
            switch(dataType)
            {
                case "integer":
                    int number = int.Parse(Console.ReadLine());
                    Console.WriteLine(number+1);
                    break;
                case "real":
                    double real = double.Parse(Console.ReadLine());
                    Console.WriteLine("{0:F2}",real+1);
                    break;
                case "text":
                    string text = Console.ReadLine();
                    Console.WriteLine(text+"*");
                    break;
            }
        }
    }
}
