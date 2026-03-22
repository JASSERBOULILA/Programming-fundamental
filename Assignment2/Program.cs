using System;
using System.Diagnostics;

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
            // Step 4 : check if the input is a valid number
            if (int.TryParse(input, out userGuess))
            {

                guesses[index] = userGuess;
                index++;
                // step 5 : did the if statement to check the user guess if it above the target temperature console too warm message if it is below the target temperature console too cold message if it is equal to the target temperature console correct message
                if (userGuess > targetTemperature)
                {

                    Console.WriteLine("Your guess is too Warm.");
                }
                else if (userGuess < targetTemperature)
                {
                    Console.WriteLine("Your guess is too Cold.");
                }
                else
                {
                    Console.WriteLine("Your guess is correct!");
                    break;
                }

            }
            // this else statement if the user typed a number that is not a valid number like characters or symboles it will print this error
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");

            }

            Console.WriteLine();
            Console.WriteLine("All your guesses were:");
            
            // last step : Show the user guesses
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(guesses[i]);
            }
        }
    }
}