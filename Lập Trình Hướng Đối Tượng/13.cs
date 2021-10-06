// Khuong Viet Tai
/*
 13.Objective (Geometry):
Write a program in C# that asks the user for a symbol, a width and a height to draw a hollow rectangle with those dimensions.
Use the symbol to paint the hollow rectangle.


Input:
	4
	3
	5

Output:
	444
	4 4
	4 4
	4 4
	444
 */










using System;
public class DrawHollowRectagle
{
    public static void Main(string[] args)
    {
        int symbol = Convert.ToInt32(Console.ReadLine());
        int width = Convert.ToInt32(Console.ReadLine());
        int height = Convert.ToInt32(Console.ReadLine());
   
        for (int row = 1; row <= height; row++)
        {
            for (int column = 1; column <= width; column++)
            {
                if ((row == 1) || (row == height))
                { 
                    Console.Write(symbol);
                }
                else
                {
                    if ((column == 1) || (column == width))
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
