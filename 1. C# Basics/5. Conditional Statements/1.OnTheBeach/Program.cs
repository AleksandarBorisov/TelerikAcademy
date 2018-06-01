using System;

namespace _1.OnTheBeach
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            string[] hours = Console.ReadLine().Split(' ');
            //DateTime loniStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, int.Parse(hours[0]), int.Parse(hours[1]), 0);
            //DateTime loniEnd = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, int.Parse(hours[2]), int.Parse(hours[3]), 0);
            //hours = Console.ReadLine().Split(' ');
            //DateTime moniStart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, int.Parse(hours[0]), int.Parse(hours[1]), 0);
            //DateTime moniEnd = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, int.Parse(hours[2]), int.Parse(hours[3]), 0);
            //int later = loniStart.CompareTo(moniStart);
            //DateTime meetingStarts = later >= 0 ? loniStart : moniStart;
            //int earlier = loniEnd.CompareTo(moniEnd);
            //DateTime meetingEnds = earlier < 0 ? loniEnd : moniEnd;
            //if (meetingStarts.CompareTo(meetingEnds) <= 0)
            //{
            //    Console.WriteLine("{0} {1} {2} {3}", meetingStarts.Hour, meetingStarts.Minute, meetingEnds.Hour, meetingEnds.Minute);
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            //По-кратко решение
            int x1 = int.Parse(hours[0]) * 60 + int.Parse(hours[1]);
            int y1 = int.Parse(hours[2]) * 60 + int.Parse(hours[3]);
            hours = Console.ReadLine().Split(' ');
            int x2 = int.Parse(hours[0]) * 60 + int.Parse(hours[1]);
            int y2 = int.Parse(hours[2]) * 60 + int.Parse(hours[3]);
            if (y1 < x2 || y2 < x1)
            {
                Console.WriteLine("No");
            }
            else
            {
                if (x2 >= x1)
                {
                    if (y1 <= y2)
                    {
                        Console.WriteLine("{0} {1} {2} {3}", x2 / 60, x2 % 60, y1 / 60, y1 % 60);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2} {3}", x2 / 60, x2 % 60, y2 / 60, y2 % 60);
                    }
                }
                else
                {
                    if (y1 <= y2)
                    {
                        Console.WriteLine("{0} {1} {2} {3}", x1 / 60, x1 % 60, y1 / 60, y1 % 60);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} {2} {3}", x1 / 60, x1 % 60, y2 / 60, y2 % 60);
                    }
                }
            }
            Main();
        }
    }
}
