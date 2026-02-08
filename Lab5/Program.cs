using System;


public class Lab5
{

    public static void Main(string[] args)
    {
        // Outer loop: iterate through rows 1 to 10
        for(int row = 1 ; row <= 10 ; row++)
        {
            // Initialize column counter for inner loop
            int col  = 1;
            // Inner loop: iterate through columns 1 to 10
            while (col <= 10)
            {
                // Calculate the product of current row and column
                int product = row * col;
                // Format output: add extra space for single-digit numbers
                if(product < (row *10))
                {
                    Console.Write(product + ",  ");
                }
                else
                {
                    Console.Write(product);
                }
                // Move to next column
                col++;
            }
            // Move to the next row after finishing all columns
            Console.WriteLine();
        }



    }

}


