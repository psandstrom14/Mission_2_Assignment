namespace Mission_2_Assignment {
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("No Time To Dice");
            Console.WriteLine("How many times would you like to roll the dice?");
            int numRolls = int.Parse(Console.ReadLine());
            DiceRollerClass diceRoller = new DiceRollerClass();
            int[] results = diceRoller.RollDice(numRolls);

            for (int i = 2; i < results.Length; i++)
            {
                double resultPercentNum = results[i] / (double)numRolls * 100;
                int roundedResultPercentNum = (int)Math.Round(resultPercentNum);
                string asterisks = "";
                for (int j = 0; j < roundedResultPercentNum; j++)
                {
                    asterisks += "*";
                }
                Console.WriteLine($"{i}: {asterisks}");
            }
        }

    }
}