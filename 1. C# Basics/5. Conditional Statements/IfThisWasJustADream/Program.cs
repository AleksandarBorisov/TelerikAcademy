using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfThisWasJustADream
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int n4 = 0;
            int n5 = 0;
            bool noZero = true;
            Console.WriteLine("Моля въведете 5 цели числа: ");
            bool isValid = false;
            while(!isValid)
            {
                Console.Write("Моля въведете първо число: ");
                isValid = Int32.TryParse(Console.ReadLine(), out n1);
            }
            isValid = false;
            while (!isValid)
            {
                Console.Write("Моля въведете второ число: ");
                isValid = Int32.TryParse(Console.ReadLine(), out n2);
            }
            isValid = false;
            while (!isValid)
            {
                Console.Write("Моля въведете трето число: ");
                isValid = Int32.TryParse(Console.ReadLine(), out n3);
            }
            isValid = false;
            while (!isValid)
            {
                Console.Write("Моля въведете четвърто число: ");
                isValid = Int32.TryParse(Console.ReadLine(), out n4);
            }
            isValid = false;
            while (!isValid)
            {
                Console.Write("Моля въведете пето число: ");
                isValid = Int32.TryParse(Console.ReadLine(), out n5);
            }
            isValid = false;
            int k1 = 0;
            int k2 = 0;
            int k3 = 0;
            int k4 = 0;
            int k5 = 0;
            for (int counter = 1; counter < 32; counter++)
            {
                k1 = counter & 1;
                k2 = (counter & 3) >> 1;
                k3 = (counter & 5) >> 2;
                k4 = (counter & 9) >> 3;
                k5 = (counter & 17) >> 4;
                int sum = k1 * n1 + k2 * n2 + k3 * n3 + k4 * n4 + k5 * n5;
                if((sum == 0) && (counter != 1) && (counter != 2) && (counter != 4) && (counter != 8) && (counter != 16))
                {
                    if (k1 != 0) Console.Write("{0} ", n1);
                    if (k2 != 0) Console.Write("{0} ", n2);
                    if (k3 != 0) Console.Write("{0} ", n3);
                    if (k4 != 0) Console.Write("{0} ", n4);
                    if (k5 != 0) Console.Write("{0} ", n5);
                    Console.WriteLine();
                    noZero = false;
                }
            }
            if (noZero == true)
            {
                Console.WriteLine("Няма нулево множество!");
            }
        }
    }
}
