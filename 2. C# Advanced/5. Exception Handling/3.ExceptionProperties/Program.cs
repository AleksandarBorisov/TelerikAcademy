using System;

namespace _3.ExceptionProperties
{
    class Program
    {
        static void Main()
        {
            try
            {
                CauseFormatException();
            }
            catch (FormatException fe)
            {
                Console.Error.WriteLine("Exception caught: {0}", fe);
                Console.Error.WriteLine("\r\nMеssage: {0}", fe.Message);
                Console.Error.WriteLine("\r\n Stack Trace: {0}", fe.StackTrace);
            }
        }

        public static void CauseFormatException()
        {
            string s = "an invalid number";
            int.Parse(s);
        }
    }
}
