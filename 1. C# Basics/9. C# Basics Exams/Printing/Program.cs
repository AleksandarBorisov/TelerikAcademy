using System;

namespace Printing
{
    class Program
    {
        static void Main()
        {
            int students = int.Parse(Console.ReadLine());
            int sheetsPerStudent = int.Parse(Console.ReadLine());
            double priceOfRealm = double.Parse(Console.ReadLine());
            double sheetsInRealm = 500;
            int totalPapers = students * sheetsPerStudent;
            double totalPapersPrice = totalPapers / sheetsInRealm * priceOfRealm;
            Console.WriteLine("{0:F2}", totalPapersPrice);
        }
    }
}
