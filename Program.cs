using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipCoinSimulation
{
    internal class HEAD_TAIL_GAME
    {
        static void Main(string[] args)
        {
            //CONSTANTS
            const int HEAD = 1;
            const int limitOfWinningTimes = 21;

            //VARIABLES
            int headCounter = 0;
            int tailCounter = 0;

            while (headCounter < limitOfWinningTimes && tailCounter < limitOfWinningTimes)
            {
                Random rand = new Random();
                int flipCoin = rand.Next(0, 2);
                if (flipCoin == HEAD)
                {
                    //Console.WriteLine("Hurray! Head wins");
                    headCounter++;
                }
                else
                {
                    //Console.WriteLine("Boorah! Tail wins");
                    tailCounter++;
                }
            }
            if (headCounter > tailCounter)
            {
                Console.WriteLine($"Head wins by {headCounter - tailCounter} times");
            }
            else if (tailCounter > headCounter)
            {
                Console.WriteLine($"Tail wins by {tailCounter - headCounter} times");
            }
            else
            {
                const int minDifferenceIfTied = 2;
                while (headCounter - tailCounter >= minDifferenceIfTied && tailCounter - headCounter >= minDifferenceIfTied)
                {
                    Random rand = new Random();
                    int flipCoin = rand.Next(0, 2);
                    if (flipCoin == HEAD)
                    {
                        headCounter++;
                    }
                    else
                    {
                        tailCounter++;
                    }
                }
            }
            Console.ReadLine();
        }
    }
}

