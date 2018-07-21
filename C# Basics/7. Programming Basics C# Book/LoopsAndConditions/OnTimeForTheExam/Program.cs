using System;

namespace OnTimeForTheExam
{
    class Program
    {
        static void Main()
        {
            int examHours = int.Parse(Console.ReadLine());
            int examMinutes = int.Parse(Console.ReadLine());
            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMinute = int.Parse(Console.ReadLine());
            int examTime = examHours * 60 + examMinutes;
            int arrivalTime = arrivalHour * 60 + arrivalMinute;
            int totalMinutesDifference = arrivalTime - examTime;
            int hoursDifference = Math.Abs(totalMinutesDifference) / 60;
            int minutesDifference = Math.Abs(totalMinutesDifference) % 60;
            string late = "Late";
            string onTime = "On time";
            string early = "Early";
            string result = "";
            string studentArrival = late;
            if (totalMinutesDifference < -30)
            {
                studentArrival = early;
            }
            else if (totalMinutesDifference <= 0)
            {
                studentArrival = onTime;
            }
            if (totalMinutesDifference != 0)
            {
                if (hoursDifference > 0)
                {
                    result = string.Format("{0}:{1:D2} hours", hoursDifference, minutesDifference);
                }
                else
                {
                    result = minutesDifference + " minutes";
                }
                if (totalMinutesDifference < 0)
                {
                    result += " before the start";
                }
                else
                {
                    result += " after the start";
                }
            }
            Console.WriteLine(studentArrival);
            if (!string.IsNullOrEmpty(result))
            {
                Console.WriteLine(result);
            }
            //Main();
        }
    }
}
