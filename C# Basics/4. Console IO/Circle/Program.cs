using System;

namespace Circle
{
    class Program
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double area = Math.PI * r * r;//Формулата се получава от разделянето на окръжността на много малки сектори 
            //и сглобяването им в правоъгълник, със страни r и 2*П*r/2=П*r
            double perimeter = 2 * Math.PI * r;//Формулата се получава от определението за П=обиколка/диаметър
            Console.WriteLine("{0:F2} {1:F2}",perimeter,area);
        }
    }
}
