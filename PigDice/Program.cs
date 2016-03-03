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
            int numOfRolls = 0;
            int totalScore = 0;
            
            //create title
            Console.WriteLine("Welcome to Pig Dice Game");
            Console.WriteLine("Please roll your dice to start the game");
            Console.ReadLine();

            // Console.Clear();
            bool keepPlaying = true;

            while (keepPlaying)
            {
                int diceNum = rnd.Next(1, 7);
                Console.WriteLine($"you have rolled {diceNum}");
                Console.ReadLine();

                if (diceNum == 1)// if 1 is rolled the game stops 
                {
                    Console.WriteLine("you lost");
                    break;
                }
                else
                {
                    Console.WriteLine("press enter to keep rolling");
                    Console.ReadLine();
                }
            }
            totalScore = numOfRolls;
        }
    }

}
