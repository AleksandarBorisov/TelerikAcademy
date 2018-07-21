using System;
//using System.IO;//За да четем от файл

namespace Ninja
{
    class Program
    {
        static void Main()
        {
            //Тестовете можем да свалим от тук http://my.telerikacademy.com/courses/Courses/Details/161
            //Посочваме пътя до файла
            //StreamReader sr = new StreamReader("C:\\Users\\Wolf\\Downloads\\Problem-6-zipped\\Tests\\ninja.20.txt");
            //int size = int.Parse(sr.ReadLine());//Четем първия ред
            //line = sr.ReadLine();//Четем втория ред
            //while (line != null)
            //{//Докато имаме стринг line
            //    line = sr.ReadLine();//Четем следващия ред
            //}
            //sr.Close();//Затваряме файла
            int size = int.Parse(Console.ReadLine());
            int[] oldMinSeconds = new int[size];//Тук пазим минималните секунди за достигане до всяка стая на горния ред
            for (int i = 0; i < size; i++)
            {
                int[] newMinSeconds = new int[size];//Тук пазим минималните секунди за достигане до всяка стая на текущия ред
                string rooms = Console.ReadLine();//.Replace(" ", "");//Стринг за положението на стаите
                for (int j = 0; j < size; j++)
                {
                    int up = oldMinSeconds[j];//Няма нужда да проверяваме дали имаме стая отгоре защото в началото OldMinSeconds е празен
                    int left = 0;
                    int min = 0;
                    if (j > 0)//В първата колона винаги ще препишем стойността отгоре
                    {//Гарантираме че ще имаме елемент отляво
                        left = newMinSeconds[j - 1];
                    }
                    if (i == 0 || j == 0)
                    {//Ако сме на първия ред или първата колона 
                        min = Math.Max(up, left);
                    }
                    else
                    {
                        min = Math.Min(up, left);
                    }
                    if (((min % 2 == 0) && (rooms[2 * j] == '1')) ||//Тъй като не махаме празните места от прочетения стринг, трябва да умножим индекса по 2
                        ((min % 2 != 0) && (rooms[2 * j] == '0')))
                    {
                        min += 2;
                    }
                    else
                    {
                        min += 1;
                    }
                    newMinSeconds[j] = min;
                }
                oldMinSeconds = newMinSeconds;
            }
            Console.WriteLine(oldMinSeconds[size - 1]);
        }
    }
}
