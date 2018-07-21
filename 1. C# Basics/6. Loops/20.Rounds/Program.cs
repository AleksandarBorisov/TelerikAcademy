using System;

namespace _20.Rounds
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            byte n = byte.Parse(Console.ReadLine());
            int travelTime = 0;
            double maxAverageSpeed = 0;
            int mostBeneficialDay = 0;
            for (int i = 1; i <= n; i++)
            {
                string[] line = Console.ReadLine().Split();
                int currentTime = int.Parse(line[0]) * 60 + int.Parse(line[1]);
                travelTime += currentTime;
                double distance = int.Parse(line[2]);
                if ((distance / currentTime) > maxAverageSpeed)
                {
                    maxAverageSpeed = (distance / currentTime);
                    mostBeneficialDay = i;
                }
            }
            int travelDays = travelTime / (60 * 24);
            int travelHours = (travelTime - travelDays * 60 * 24) / 60;//Оптимизиране hoursLeft = travelTime % (60 * 24), travelHours = hoursLeft / 60
            int travelMinutes = travelTime - travelDays * 60 * 24 - travelHours * 60;//Оптимизиране travelMinutes = hoursLeft % 60
            Console.WriteLine($"{travelDays} {travelHours} {travelMinutes} {mostBeneficialDay}");
        }
    }
}
