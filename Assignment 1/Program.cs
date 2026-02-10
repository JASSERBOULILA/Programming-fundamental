using System;


public static class Assignment1
{

    public static void Main(string[] args)
    {
        // three strings to store the price of each type of flooring
        string hardwood = "8.95";
        string carpet = "7.95";
        string laminate = "6.95";


        // variable to store the user choice
        string userChoice = "";

        // variable to represent the length and of a romm
        string length = "";
        string width = "";

        Console.WriteLine("Enter the length of the room in feet:");
        length = Console.ReadLine();
        Console.WriteLine("Enter the width of the room in feet:");
        width = Console.ReadLine();

        // check if the user has inputted a number
        if (!int.TryParse(length, out int result) || !int.TryParse(width, out result))
        {
            Console.WriteLine("Invalid input. Please enter a number.");

        }

        // ask the user about the flooring choice
        Console.WriteLine("What type of flooring would you like?");
        Console.WriteLine($"A. Hardwood (${hardwood} per sq ft)");
        Console.WriteLine($"B. Carpet (${carpet} per sq ft)");
        Console.WriteLine($"C. Laminate (${laminate} per sq ft)");
        Console.WriteLine("Please enter A, B, or C:");
        userChoice = Console.ReadLine().ToUpper();

        // check the user input choice
        switch (userChoice)
        {
            case "A":
                userChoice = "A";
                break;
            case "B":
                userChoice = "B";
                break;
            
            case "C":
                userChoice = "C";
                break;

            default:
                Console.WriteLine("Invalid input. Please enter A, B, or C.");
                break;
        }

    }
}