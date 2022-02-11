using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoinSimulation
{
    internal class HEAD_TAIL_GAME
    {
        static void Main(string[] agrs)
        {
            //CONSTANTS
            const int HEAD = 1;
            const int limitofWinningTimes = 21;

            //VARIABLES
            int headcounter = 0;
            int tailcounter = 0;

            while (headcounter < limitofWinningTimes && tailcounter < limitofWinningTimes)
            {
                Random random = new Random();
                int flipcoin = random.Next(0, 2);
                if (flipcoin == HEAD)
                {
                    //Console.WriteLine("Hurry! Head wins");
                    headcounter++;

                }
                else
                {
                    //Console.WriteLine("Boorah! Tail wins");
                    tailcounter++;
                }
            }
            if (headcounter > tailcounter)
            {
                Console.WriteLine($"Head wins by {headcounter - tailcounter} times");

            }
            else if (tailcounter > headcounter)
            {
                Console.WriteLine($"Tail wins by {tailcounter - headcounter}times");
            }
            else
            {
                const int minDifferenceifTail = 2;
                while (headcounter - tailcounter >= minDifferenceifTail && tailcounter - headcounter >= minDifferenceifTail) ;
                {
                    Random rand = new Random();
                    int flipcoin = rand.Next(0, 2);
                    if (flipcoin == HEAD)
                    {
                        headcounter++;
                    }
                    else
                    {
                        tailcounter++;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}

