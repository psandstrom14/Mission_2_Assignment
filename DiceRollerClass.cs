using System;
using System.Collections.Generic;
using System.Text;

namespace Mission_2_Assignment
{
    internal class DiceRollerClass
    {
        public int[] RollDice(int numRolls)
        {
            Random rand = new Random();
            int[] results = new int[13];
            for (int i = 0; i < numRolls; i++)
            {
                int die1 = rand.Next(1, 7);
                int die2 = rand.Next(1, 7);
                int result = die1 + die2;
                results[result]++;
            }
            return results;
        }
    }
}
