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

            Random random = new Random();
            int flipcoin = random.Next(0, 2);
            if (flipcoin == HEAD)
            {
                Console.WriteLine("Hurry! Head wins");

            }
            else
            {
                Console.WriteLine("Boorah! Tail wins");
            }
            Console.ReadLine();
        }
    }
}


