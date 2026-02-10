using System ; 


public static class Assignment1
{
    
    public static void Main(string[] args)
    {
        // three strings to store the price of each type of flooring
        string hardwood = "8.95";
        string carpet = "7.95";
        string laminate = "6.95";


        // variable to store the user choice
        string userChoice = Console.ReadLine();
        
        // variable to represent the length and of a romm
        string length = "";
        string width = "";

        Console.WriteLine("Enter the length of the room in feet:");
        length = Console.ReadLine();
        Console.WriteLine("Enter the width of the room in feet:");
        width = Console.ReadLine();

        // check if the user has inputted a number
        if(!int.TryParse(length, out int result) || !int.TryParse(width, out result))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
            
        }


    }
}