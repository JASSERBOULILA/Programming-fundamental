using System;

class Assignment2
{
    static void Main()
    {
        // step1 : create the random variables
        Random random = new Random();
        int targetTemperature = random.Next(10, 41); // 10 to 40

        // step 2 : created the array to store the user guesses
        int[] guesses = new int[100]; 
        int index = 0;
        int userGuess = 0; 

        // simple comment to start the game instructions
        Console.WriteLine("=== Temperature History Game ===");
        Console.WriteLine("Try to guess the temperature between 10 and 40.");
        // used the while loop to run the game because we dont have any array or limit on the number of guesses
        while (true)
        {
            // STEP 3  : ask the user to enter their guess
            Console.Write("Enter your guess: ");
            string input = Console.ReadLine();

        }
    }
}