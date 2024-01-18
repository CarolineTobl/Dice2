using System;

// Main Program Class 
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.Write("How many times would you like to roll 2 6-sided dice? ");

        // Attempt to parse the input. If it fails, prompt the user again.
        if (!int.TryParse(Console.ReadLine(), out int numberOfRolls))
        {
            Console.WriteLine("Invalid input. Please enter an integer.");
            return; // Exit if input is invalid
        }

        // Now we have a valid number of rolls, we can call the RollDice method
        int[] results = DiceSimulator.RollDice(numberOfRolls);

        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {numberOfRolls}.");

        // Loop through each sum and calculate the percent occurrence 
        for (int i = 2; i <= 12; i++)
        {
            // Calculate the percentage that each sum occurred
            int percentage = (results[i] * 100) / numberOfRolls;
            Console.Write($"{i}: ");
            for (int j = 0; j < percentage; j++)
            {
                Console.Write("*"); // Print asterisks based on the percentage
            }
            Console.WriteLine();
        }

        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}
