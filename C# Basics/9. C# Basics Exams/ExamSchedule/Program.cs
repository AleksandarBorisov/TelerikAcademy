using System;

namespace ExamSchedule
{
    class Program
    {
        static void Main()
        {
            //while (true)
            //{
                int hourStart = int.Parse(Console.ReadLine());
                int minuteStart = int.Parse(Console.ReadLine());
                string partOfDay = Console.ReadLine();
                int hourExam = int.Parse(Console.ReadLine());
                int minutesExam = int.Parse(Console.ReadLine());
                if (partOfDay == "PM")
                {//Защото парсването на DateTime е винаги в 24 часов формат
                    hourStart += 12;
                }
                DateTime examStart = new DateTime(2017, 09, 15, hourStart, minuteStart, 0);
                DateTime examEnds = examStart.AddHours(hourExam).AddMinutes(minutesExam);
                Console.WriteLine("{0:hh:mm:tt}", examEnds);
                Console.WriteLine();
            //}
        }
    }
}
