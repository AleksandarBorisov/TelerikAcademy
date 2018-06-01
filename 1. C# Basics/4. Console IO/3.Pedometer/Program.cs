using System;

namespace _3.Pedometer
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            Console.WriteLine(Convert.ToInt32(Console.ReadLine()) * 1609);
            //Този метод работи малко по-бързо от int.Parse
        }
    }
}
