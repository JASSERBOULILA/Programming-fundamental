using System;

public static class Assignment1
{
    public static void Main(string[] args)
    {
        // Step 1: three strings to store the price of each type of flooring
        string hardwood = "8.95";
        string carpet = "7.95";
        string laminate = "6.95";

        // Step 2: variable to store the user choice
        string userChoice = "";

        // Step 3: variables to represent the length and width of a room
        string lengthInput = "";
        string widthInput = "";
        double length = 0;
        double width = 0;

        // Step 4: Ask the user the length of the room
        Console.WriteLine("Enter the length of the room in feet:");
        lengthInput = Console.ReadLine();

        // Step 5: Check if the user has inputted a number for length
        if (double.TryParse(lengthInput, out length))
        {
            // Valid number - stored in length variable
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number for length.");
            return; // Exit the program
        }

        // Step 6: Ask the user the width of the room
        Console.WriteLine("Enter the width of the room in feet:");
        widthInput = Console.ReadLine();

        // Step 7: Check if the user has inputted a number for width
        if (double.TryParse(widthInput, out width))
        {
            // Valid number - stored in width variable
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid number for width.");
            return; // Exit the program
        }

        // Step 8: Ask the user about the flooring choice
        Console.WriteLine("What type of flooring would you like?");
        Console.WriteLine($"A. Hardwood (${hardwood} per sq ft)");
        Console.WriteLine($"B. Carpet (${carpet} per sq ft)");
        Console.WriteLine($"C. Laminate (${laminate} per sq ft)");
        Console.WriteLine("Please enter A, B, or C:");
        userChoice = Console.ReadLine().ToUpper();

        // Step 9: Check if the user has inputted a valid letter
        if (userChoice == "A" || userChoice == "B" || userChoice == "C")
        {
            //already stored in userChoice
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter A, B, or C.");
            return; // Exit the program
        }

        // Step 10: Create a series of if() statements for each flooring choice
        if (userChoice == "A")
        {
            // Hardwood selected
            Console.WriteLine("You selected Hardwood flooring.");
        }
        else if (userChoice == "B")
        {
            // Carpet selected
            Console.WriteLine("You selected Carpet flooring.");
        }
        else if (userChoice == "C")
        {
            // Laminate selected
            Console.WriteLine("You selected Laminate flooring.");
        }
    }
}