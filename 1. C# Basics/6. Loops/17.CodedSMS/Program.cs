using System;
using System.Text;

namespace _17.CodedSMS
{
    class Program
    {//Задача от judge.telerikacademy
        static void Main()
        {
            string message = Console.ReadLine();
            //StringBuilder result = new StringBuilder();
            string result = "";
            string stringSoFar = "";
            for (int i = 0; i < message.Length; i++)
            {
                //result.Append(result).Insert(result.Length / 2, message[i]);
                result = stringSoFar + message[i] + stringSoFar;
                stringSoFar = result;
            }
            Console.WriteLine(result.ToString());
        }
    }
}
