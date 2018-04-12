using System;

namespace Money
{
    class Program
    {
        static void Main()
        {
            int numberOfStudents = int.Parse(Console.ReadLine());
            int sheetsForStudent = int.Parse(Console.ReadLine());
            double sheetsOFRealm = 400;
            double priceOFRealm = double.Parse(Console.ReadLine());
            double result = numberOfStudents * sheetsForStudent / sheetsOFRealm * priceOFRealm;
            Console.WriteLine("{0:F3}",result);
        }
    }
}
