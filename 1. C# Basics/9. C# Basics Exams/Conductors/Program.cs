using System;

namespace Conductors
{
    class Program
    {
        static void Main()
        {
            int perforatingDevice = int.Parse(Console.ReadLine());
            int ticketsCount = int.Parse(Console.ReadLine());
            int bitCounter = 0;
            int bitsOfPerforatingDevice = perforatingDevice;
            for (int i = 0; i < ticketsCount; i++)
            {
                //while (bitsOfPerforatingDevice != 0)
                //{
                //    bitsOfPerforatingDevice >>= 1;
                //    bitCounter++;
                //}
                //bitsOfPerforatingDevice = perforatingDevice;
                bitCounter = Convert.ToString(perforatingDevice, 2).Length;
                int ticket = int.Parse(Console.ReadLine());
                for (int j = 0; j < 32 - bitCounter; j++)
                {//Може и с while цикъл като условието ще бъде while((perforatingDevice & (1 << 31)) == 0)
                    int perforator = (perforatingDevice << j);
                    if ((ticket & perforator) == perforator)
                    {
                        ticket &= ~(perforator);
                    }
                }
                Console.WriteLine(ticket);
            }
           
        }
    }
}
