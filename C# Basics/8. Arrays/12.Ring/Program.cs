using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Ring
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            //Последния кейс не мина
            string[] line = Console.ReadLine().Split();
            int n = int.Parse(line[0]);
            int k = int.Parse(line[1]);
            int[,] students = new int[n + 1, 2];
            //В нулевата колона се пазят К-номерата на всеки ученик
            //В първата колона се пази следващия номер на ученик в кръга, т.е. индекса който ни интересува
            for (int i = 1; i <= n; i++)
            {
                students[i, 0] = int.Parse(Console.ReadLine());
                students[i, 1] = i + 1;//1-вия ни препраща към 2-ие, 2-ия към 3-ия и т.н.
            }
            students[n, 1] = 1;//Т.е. след като стигнем до последния индекс, започваме да броим от елемента, който стои на първия индекс
            int counter = 1;//Започваме от индекс 1, където е първия ученик, все едно него вече сме го преброили
            //PrintStudents(students);
            for (int i = 1; i <= n - 1; i++)
            {//Трябва да махнем точно n - 1 ученика, за да остане последния
                for (int j = 2; j < k; j++)
                {//К неможе да е по малко от 2, а ако е равно на 2 то counter-а вече сочи към индекса на елемента, който да вземем
                    //Този цикъл ще се изпълни колкото е разликата между K и 2
                    counter = students[counter, 1];//Взимаме следващите индекси до К - 1
                    //Т.е. брояча ни пази индеса на ученика, който пази индекса на следващия ученик
                }
                int removeStudentIndex = students[counter, 1];//Взимаме индекса, към който сочи counter-a и "премахваме" ученика на него
                k = students[removeStudentIndex, 0];//Запазваме К-номера на ученика
                students[counter, 1] = students[removeStudentIndex, 1];//Ученика до който е стигнал брояча просто взима адреса, 
                //към който е сочил ученика който сме извадили, щом не се реферира, то "извадения" ученик няма и да се преброява
                counter = students[removeStudentIndex, 1];//Брояча преброява следващия елемент след "извадения"
                //PrintStudents(students);
            }
            Console.WriteLine(counter);

            //private static void PrintStudents(int[,] forPrinting)
            //{
            //    Console.WriteLine($" K R i");
            //    for (int i = 0; i < forPrinting.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < forPrinting.GetLength(1); j++)
            //        {
            //            Console.Write($"{forPrinting[i, j],2}");
            //        }
            //        Console.WriteLine($"{i,2}");
            //    }
            //    Console.WriteLine();
            //}

            //Лимит време след 6 кейс
            //string[] line = Console.ReadLine().Split();
            //int n = int.Parse(line[0]);
            //int k = int.Parse(line[1]);
            //List<int[]> students = new List<int[]>();
            //for (int i = 0; i < n; i++)
            //{
            //    int[] student = new int[] { int.Parse(Console.ReadLine()), i + 1 };
            //    students.Add(student);
            //}
            //for (int i = 1; i <= n - 1; i++)
            //{//Трябва да махнем точно n - 1 ученика, за да остане последния
            //    k--;//защото броим от 0
            //    if (k < 0 )
            //    {
            //        k += students.Count;
            //    }
            //    int removeStudentK = students[k][0];
            //    students.RemoveAt((k)% students.Count);
            //    k = (k + removeStudentK) % students.Count;
            //}
            //Console.WriteLine("{0}", students.FirstOrDefault()[1]);
        }
    }
}
