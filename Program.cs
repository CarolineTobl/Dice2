using System;

public class DiceSimulator //Create a new Public Class 
{
    public static int[] RollDice(int numberOfRolls) //public static method named RollDice in the DiceSimulator class. It takes one integer parameter numberOfRolls and returns an array of integers.
    {
        int[] rollResults = new int[13]; // Array indices that the numbers 2-12 will be used

        Random rand = new Random(); //Create the Object for where the random numbers will be generated
        for (int i = 0; i < numberOfRolls; i++) // For loop iterates through rolling the die each time.
        {
            int roll = rand.Next(1, 7) + rand.Next(1, 7); // Roll the two dice for numbers between 1-6
            rollResults[roll]++; //Add the two Number of Die to eachother.
        }

        return rollResults; // return the added together number
    }
}

class Program //new class called Program
{
    static void Main(string[] args) //does not return anything
    {
        Console.WriteLine("Welcome to the dice throwing simulator!"); //Write to Console.
        Console.Write("How many times would you like to roll 2 6-sided dice? "); // Write to Console
        int numberOfRolls = int.Parse(Console.ReadLine()); //Take the user input and convert to an integer and store to numberOfRolls variable

        int[] results = DiceSimulator.RollDice(numberOfRolls); //Call DiceSimulator and RollDice Method

        Console.WriteLine("DICE ROLLING SIMULATION RESULTS"); //Write to Console
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls."); //Write to Console
        Console.WriteLine($"Total number of rolls = {numberOfRolls}."); //Write to Console and print numberOfRolls Variable

        for (int i = 2; i <= 12; i++) //Start iterating through all the possible dice roll sums. 2-12
        {
            int percentage = (results[i] * 100) / numberOfRolls; //Take the sum and calculate the percentage that that sum happened out of the number 
            Console.Write($"{i}: ");
            for (int j = 0; j < percentage; j++)
            {
                Console.Write("*"); // Depending on the percent, show that number of astricks.
            }
            Console.WriteLine();
        }

        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!"); //Write to Console Log
    }
}