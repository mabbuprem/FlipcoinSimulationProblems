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
            const int TAIL = 0;
            const int flipCoinconter = 20;

            //VARIABLES
            int headcounter = 0;
            int tailcounter = 0;
            int i = 0;

            while (i < flipCoinconter)
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
        i++;
                Console.WriteLine($"Head wins {headcounter}");
                Console.WriteLine($"Tail wins {tailcounter}");
                Console.ReadLine();
        }
    }
}


