using System;

namespace PlayCard
{
    class Program
    {
        static void Main()
        {
            string card = Console.ReadLine();
            int digit;
            bool parseSuccess = Int32.TryParse(card, out digit);
            if (digit >= 2 && digit <= 10)
            {
                Console.WriteLine("yes " + digit);
            }
            else
            {
                switch (card)
                {
                    case "J": Console.WriteLine("yes " + card); break;
                    case "Q": Console.WriteLine("yes " + card); break;
                    case "K": Console.WriteLine("yes " + card); break;
                    case "A": Console.WriteLine("yes " + card); break;
                    default: Console.WriteLine("no " + card); break;
                }
            }
        }
    }
}
