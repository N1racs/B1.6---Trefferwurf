using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B1._6___Trefferwurf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string yourDiceNumber = ("Dein Wurf: ");
            string goalOutput = ("Zielwert: ");
            string totalOutput = (" - Gesamtwert: ");
            string hitMessage = ("Treffer!");
            string missMessage = ("Verfehlt!");

            Random random = new Random();
            Console.Write(yourDiceNumber);
            int rollDice = RollDice(random);
            Console.WriteLine(rollDice);
            int attackBonus = GetAttackBonus();
            int total = rollDice + attackBonus;
            int goal = random.Next(10, 21);
            Console.WriteLine(goalOutput + goal + totalOutput + total);
            bool isHit = CheckHit(total, goal);
            if (isHit)
            {
                Console.WriteLine(hitMessage);
            }
            else
            {
                Console.WriteLine(missMessage);
            }
        }

        /// <summary>
        /// Generates a random dice roll between 1 and 20.
        /// </summary>
        /// <param name="random"></param>
        /// <returns></returns>
        static int RollDice(Random random)
        {

            return random.Next(1, 21);
        }

        /// <summary>
        /// Returns the attack bonus entered by the user.
        /// </summary>
        /// <returns></returns>
        static int GetAttackBonus()
        {
            string attackMessage = ("Gib deinen Angriffsbonus ein:");


            Console.WriteLine(attackMessage);
            Console.Write("> ");
            int attackBonus = int.Parse(Console.ReadLine());
            return attackBonus;
        }

        /// <summary>
        /// Checks if the total value is greater than or equal to the goal
        /// </summary>
        /// <param name="total"></param>
        /// <param name="goal"></param>
        /// <returns></returns>
        static bool CheckHit(int total, int goal)
        {
            return total >= goal;
        }


    }
}   
