// Khuong Viet Tai


/*
 * 2. Objective(Geometry):
Write a program in C# that asks for a symbol and a width to paint a triangle of that width and height using that number to draw it.

Input : 7
	5


Output:
	77777
	7777
	777
	77
	7
*/

using System;
public class Geometry
{
    public static void Main(string[] args)
    {
	// Create x and Enter data x
        int x = Convert.ToInt32(Console.ReadLine());
	
	// Create and Enter data width
        int width = Convert.ToInt32(Console.ReadLine());

	// Create height and assign value equal to width
        int height = width;
	
	//create a loop that attaches row = 0 and row < height and row = 0 to height -1  
        for (int row = 0; row < height; row++)
        {
		//create a loop that attaches column = 0 and column < width and column = 0 to width -1
            for (int column = 0; column < width; column++)
            {
                Console.Write(x);
            }
 
            Console.WriteLine();
            width--;
        }
    }
}
