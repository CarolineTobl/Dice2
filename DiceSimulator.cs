using System;


//Second Class Dice Simulator 
public class DiceSimulator
{
    public static int[] RollDice(int numberOfRolls)
    {
        int[] rollResults = new int[13]; // Array indices 2-12 will be used

        Random rand = new Random();
        for (int i = 0; i < numberOfRolls; i++)
        {
            // Roll two dice for numbers between 1-6 and add the results
            int roll = rand.Next(1, 7) + rand.Next(1, 7);
            rollResults[roll]++;
        }

        return rollResults; // Return the roll results array
    }
}
