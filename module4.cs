using System;


namespace Module4
{

    internal class Module4
    {
        public static void Run()
        {


            /* STEP 1: List out the ride choices
            ﻿A) Casual Carousel (no age limit)
            ﻿B) Bumpy Boats (minimum 5 years)
            ﻿C) Rowdy Road Race (minimum 7 years)
            ﻿D) Tunnel of Terror (minimum 12 years / maximum 70 years)*/
            Console.Clear();
            Console.WriteLine("SECOND PROGRAM");

            Console.WriteLine("Welcome to fantastic Fair \r\nPlease choose a ride \r\nA) Casual Carousel (no age limit)\r\nB) Bumpy Boats (minimum 5 years)\r\nC) Rowdy Road Race (minimum 7 years)\r\nD) Tunnel of Terror (minimum 12 years / maximum 70 years)");

            // STEP 2a: Ask the user to pick a ride and store it as a string

            string choice = Console.ReadLine();

            // STEP 2b: Trim any whitespace from the input, and capitalize it

            choice = choice.Trim().ToUpper();

            // STEP 2c: Output the guest's choice

            Console.WriteLine($"You picked {choice}");

            // STEP 3a: Ask the rider how old they are and store it as a string

            Console.WriteLine("How old are you?");
            string riderAgeString = Console.ReadLine();

            // STEP 3b: Try to convert the input to an integer - declare a variable to contain the number
            int riderAge;
            // STEP 3c: Create a boolean variable that attempts to parse the rider's age into an integer (https://learn.microsoft.com/en-us/dotnet/api/system.int32.tryparse?view=net-6.0)
            bool isParsable = Int32.TryParse(riderAgeString, out riderAge);
            // STEP 3d: If the riderAgeString can be converted to an integer, and they picked a ride, then we can proceed to see what ride they chose
            if (isParsable && choice != "")
            {
                switch (choice)
                {

                    // STEP 4a: They picked ride "A"...
                    case "A":
                        // STEP 4b: There are no age limits for this ride... let them know they can ride
                        Console.WriteLine("You can ride the Casual Carousel");

                        break;
                    // STEP 5a: They picked ride "B"...
                    case "B":
                        // STEP 5b: Check to see if they are at least 5, if not tell them they cannot ride
                        if (riderAge >= 5)
                        {
                            Console.WriteLine("You can ride the Bumpy Boats");
                        }
                        else
                        {
                            Console.WriteLine("You are not old enough to ride the Bumpy Boats");
                        }

                        break;
                    // STEP 6a: They picked ride "C"...
                    case "C":
                        // STEP 6b: Check to see if they are at least 7, if not let them know they cannot ride
                        if (riderAge >= 7)
                        {
                            Console.WriteLine("You can ride the Rowdy Road Race");
                        }
                        else
                        {
                            Console.WriteLine("You are not old enough to ride the Rowdy Road Race");
                        }

                        break;

                    // STEP 7a: They picked ride "D"...
                    case "D":

                        // STEP 7b: First we check if they are old enough to go on this ride

                        if (riderAge >= 12)
                        {
                            // STEP 7e: they are too old - let them know they cannot ride
                            if (riderAge > 70)
                            {
                                Console.WriteLine("You are too old to ride the Tunnel of Terror");
                            }
                            // STEP 7f: They are neither too old nor too young - they can ride!
                            else

                            {

                                Console.WriteLine("You can ride the tunel");
                            }
                        }
                        // STEP 7c: They are not old enough to ride this attraction
                        else
                        {
                            Console.WriteLine("You cannot ride the Tunnel of Terror");
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
            // STEP 3e: The park guest did not enter a valid age or they didn't pick a ride - let them know they can't ride
            else
            {
                Console.WriteLine("you can't Ride");
            }
        }
    }
}

























// STEP 8: What situation will this program not be able to deal with?﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿﻿
