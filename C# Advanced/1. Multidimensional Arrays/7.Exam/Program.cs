using System;

namespace _7.Exam
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            string[] line = Console.ReadLine().Split();
            byte n = byte.Parse(line[0]);
            byte l = byte.Parse(line[1]);
            byte r = byte.Parse(line[2]);
            sbyte[] students = new sbyte[n + 1];
            line = Console.ReadLine().Split();
            for (byte i = 0; i < l; i++)
            {//Учениците, които нямат химикал означаваме с -1
                students[byte.Parse(line[i])] = -1;
            }
            line = Console.ReadLine().Split();
            for (byte i = 0; i < r; i++)
            {
                byte studentNumber = byte.Parse(line[i]);
                if (studentNumber > 1 && students[studentNumber - 1] == -1)
                {//Дали сме след първия и предишния е нямал химикал
                    students[studentNumber - 1] = 0;
                }
                else if (studentNumber < n && students[studentNumber + 1] == -1)
                {
                    students[studentNumber + 1] = 0;
                }
            }
            byte countExpelled = 0;
            foreach (var student in students)
            {
                if (student < 0)
                {
                    countExpelled++;
                }
            }
            Console.WriteLine(countExpelled);


            //Вярно решение, но поради някаква причина не минават всички кейсове в judge
            //string[] line = Console.ReadLine().Split();
            //byte n = byte.Parse(line[0]);
            //byte l = byte.Parse(line[1]);
            //byte r = byte.Parse(line[2]);
            //sbyte[] students = new sbyte[n + 1];
            //string[] withoutPen = Console.ReadLine().Split();
            //string[] sparePen = Console.ReadLine().Split();
            //for (byte i = 1; i < n + 1; i++)
            //{
            //    if (Array.IndexOf(withoutPen, i.ToString()) >= 0)
            //    {
            //        students[i] = -1;
            //    }
            //    if (Array.IndexOf(sparePen, i.ToString()) >= 0)
            //    {
            //        if (i > 1 && students[i - 1] == -1)
            //        {
            //            students[i - 1] = 0;
            //        }
            //        else if (i < n && students[i + 1] == -1)
            //        {
            //            students[i + 1] = 0;
            //        }
            //    }
            //}
            //byte countExpelled = 0;
            //foreach (var student in students)
            //{
            //    if (student < 0)
            //    {
            //        countExpelled++;
            //    }
            //}
            //Console.WriteLine(countExpelled);
        }
    }
}
