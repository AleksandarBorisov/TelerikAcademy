using System;

namespace Grades
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            double sumOfAllGrades = 0;
            int countOfFailed = 0;
            int countOfAverage = 0;
            int countOfGood = 0;
            int countOfExcellent = 0;
            double countOf3Treshold = 3.00;
            double countOf4Treshold = 4.00;
            double countOf5Treshold = 5.00;
            for (int i = 1; i <= n; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                sumOfAllGrades += grade;
                if (grade < countOf3Treshold)
                {
                    countOfFailed++;
                }
                else if (countOf3Treshold <= grade && grade < countOf4Treshold)
                {
                    countOfAverage++;
                }
                else if (countOf4Treshold <= grade && grade < countOf5Treshold)
                {
                    countOfGood++;
                }
                else
                {
                    countOfExcellent++;
                }
            }
            Console.WriteLine("Top students: {0:F2}%", (double)countOfExcellent *100/ n);
            Console.WriteLine("Between 4.00 and 4.99: {0:F2}%", (double)countOfGood * 100 / n);
            Console.WriteLine("Between 3.00 and 3.99: {0:F2}%", (double)countOfAverage * 100 / n);
            Console.WriteLine("Fail: {0:F2}%", (double)countOfFailed * 100 / n);
            Console.WriteLine("Average: {0:F2}", sumOfAllGrades / n);
        }
    }
}
