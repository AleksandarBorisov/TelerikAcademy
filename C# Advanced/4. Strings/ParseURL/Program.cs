using System;

namespace ParseURL
{
    class Program
    {
        static void Main()
        {
            string adress = Console.ReadLine();
            int endOfProtocol = adress.IndexOf(":");
            int startOfServer = adress.IndexOf("//");
            int startOfResource = adress.IndexOf("/",startOfServer + 2);
            Console.WriteLine($"[protocol] = {adress.Substring(0, endOfProtocol)}");
            Console.WriteLine($"[server] = {adress.Substring(startOfServer + 2, startOfResource - (startOfServer + 2))}");
            Console.WriteLine($"[resource] = {adress.Substring(startOfResource)}");
        }
    }
}
