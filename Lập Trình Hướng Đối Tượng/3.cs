// Khuong Viet Tai


/*

   3. Objective(Geometry):
Write a program in C # that requests a width and shows a northeast triangle. Use the * character to paint the triangle.

Input :
	5

Output:

	*****
	 ****
	  ***
	   **
	    *



*/ 



using System;
public class DrawTriangleNorthEast
{
    public static void Main()
    {
        int height = Convert.ToInt32(Console.ReadLine());
        int width = 0;
        int max = height;
 
        for (int row = 0; row < height; row++)
        {
            for (int column = 0; column < width; column++)
            {
                Console.Write(" ");
            }
 
            for (int symbols = 0; symbols < max; symbols++)
            {
                Console.Write("*");
            }
 
            Console.WriteLine();
 
            width++;
            max--;
        }
    }
}
