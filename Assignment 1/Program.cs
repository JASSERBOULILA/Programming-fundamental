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
        int length = 0;
        int width = 0;

        Console.WriteLine("Enter the length of the room in feet:");
        length = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the width of the room in feet:");
        width = Convert.ToInt32(Console.ReadLine());

        


    }
}