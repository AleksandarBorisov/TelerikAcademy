using System;

namespace SignalFromSpace
{
    class Program
    {
        static void Main()
        {
            string message = Console.ReadLine();
            string decodedMessage = "" + message[0];
            for (int i = 1; i < message.Length; i++)
            {
                if (message[i] != message[i - 1])
                {
                    decodedMessage += message[i];
                }
            }
            Console.WriteLine(decodedMessage);

            //Това решение използва по-малко памет от първото, но като скорост е същото
            //char previousSymbol = (char)Console.Read();
            //while (previousSymbol != '\n')//Защото тестовата система използва за край на реда само този знак
            //{
            //    char nextSymbol = (char)Console.Read();
            //    if (nextSymbol != previousSymbol)
            //    {
            //        Console.Write(previousSymbol);
            //    }
            //    previousSymbol = nextSymbol;
            //}
        }
    }
}
