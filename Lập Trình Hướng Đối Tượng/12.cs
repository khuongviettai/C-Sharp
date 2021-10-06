// Khuong Viet Tai
/*
 12.Objective (Geometry):
Write a program in C# that asks for a symbol and a width that you will use to draw the hollow square of that width and height.
Use the symbol to draw the hollow square, the height will be the same as the width.

Input:
	1
	5
Output:
	11111
	1   1
	1   1
	1   1
	11111
 */









using System;
public class DrawHollowRectagle
{
    public static void Main(string[] args)
    {
        int symbol = Convert.ToInt32(Console.ReadLine());
        int height = Convert.ToInt32(Console.ReadLine());
   
        for (int row = 1; row <= height; row++)
        {
            for (int column = 1; column <= height; column++)
            {
                if ((row == 1) || (row == height))
                { 
                    Console.Write(symbol);
                }
                else
                {
                    if ((column == 1) || (column == height))
                    { 
                        Console.Write(symbol);
                    }
                    else
                    { 
                        Console.Write(" ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
