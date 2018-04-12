using System;

namespace BobbyAvokadoto
{
    class Program
    {
        static void Main()
        {
            uint n = uint.Parse(Console.ReadLine());
            //Console.WriteLine((Convert.ToString(n,2)));
            int numberOfCombs = int.Parse(Console.ReadLine());
            uint maxTeethDontOverlap = 0;
            uint perfectComb = 0;
            for (int i = 0; i < numberOfCombs; i++)
            {
                uint comb = uint.Parse(Console.ReadLine());
                if ((comb & n) == 0)
                {//comb is valid
                    //count teeth
                    uint combTeethDontOverlap = 0;
                    for (int j = 0; j < 32 && (comb >> j) > 0; j++)
                    {
                        combTeethDontOverlap += (comb >> j) & 1;
                    }
                    //check if best
                    if (combTeethDontOverlap > maxTeethDontOverlap)
                    {
                        maxTeethDontOverlap = combTeethDontOverlap;
                        perfectComb = comb;
                    }
                }
            }
            Console.WriteLine(perfectComb);
        }
    }
}
