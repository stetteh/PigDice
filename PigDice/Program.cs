using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDice
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //create title
            Console.WriteLine("Welcome to Pig Dice Game");
            Console.WriteLine("Please rol your dice to start the game");
            Console.ReadLine();

            // Console.Clear();

            int diceNum = rnd.Next(1, 7);
            Console.WriteLine($"you have rolled {diceNum}");
            Console.ReadLine();

            if(diceNum == 1)
            {
                Console.WriteLine("you lost");
                break;
            }

        }
    }

}
