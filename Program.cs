using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose a lab to run:");
        Console.WriteLine("1) Lab1");
        Console.WriteLine("2) Lab2");
        Console.WriteLine("3) Lab3");
        Console.WriteLine("4) Lab4");
        Console.WriteLine("5) Module4");
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "2":
                Lab2.Run();
                break;
            case "3":
                Lab3.Run();
                break;
            case "4":
                Lab4.Run();
                break;
            case "5":
                Module4.Module4.Run();
                break;
            default:
                Console.WriteLine("Invalid choice");
                break;
        }
    }
}
