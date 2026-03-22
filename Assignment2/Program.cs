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
    }
}