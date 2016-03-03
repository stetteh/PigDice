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
            int TotalRolls = 0;
            int totalScore = 0;
            
            //create title
            Console.WriteLine("Welcome to Pig Dice Game");
            Console.WriteLine("Please roll your dice to start the game");
            Console.ReadLine();

            // Console.Clear();
            bool keepPlaying = true;
            while (totalScore < 100)
            {
                while (keepPlaying)
                {
                    int diceNum = rnd.Next(1, 7);
                    Console.WriteLine($"you have rolled {diceNum}");
                    Console.ReadLine();

                    if (diceNum == 1)// if 1 is rolled the game stops 
                    {
                        TotalRolls = 0;
                        Console.WriteLine("you lost");
                        break;
                    }
                    totalScore += TotalRolls;
                    Console.WriteLine($"Your turn total score is {TotalRolls}. you game total is {totalScore}");
                    if (totalScore > 100)
                    {
                        TotalRolls += diceNum;
                        Console.WriteLine($"press enter to keep rolling and your score is {totalScore}");
                        Console.ReadLine();
                    }
                }
                
            }
        }
    }

}
