using System;

namespace Hospital
{
    class Program
    {
        static void Main()
        {
            //Console.Write("Въведете период за проверка: ");
            int lastDay = int.Parse(Console.ReadLine());
            int patients = 0;
            int doctors = 7;
            int treatedPatients = 0;
            int unTreatedPatients = 0;
            for (int currentDay = 1; currentDay <= lastDay; currentDay++)
            {
                if ((currentDay % 3 == 0) && (unTreatedPatients > treatedPatients))
                {
                    doctors++;
                }
                //Console.Write($"Брой пациенти за {currentDay}-ия ден: ");
                patients = int.Parse(Console.ReadLine());
                if (patients > doctors)
                {
                    unTreatedPatients += patients - doctors;
                    treatedPatients += doctors;
                }
                else
                {
                    treatedPatients += patients;
                }
            }
            Console.WriteLine($"For the last {lastDay} days we have\nTreated patients: {treatedPatients}.\nUntreated patients: {unTreatedPatients}.");
        }
    }
}
