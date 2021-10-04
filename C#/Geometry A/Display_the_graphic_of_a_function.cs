/*
Create a program C# to draw the graphic of the function y=(x-4)² for a range of integer values of x requested from the user.

Input

	-1
	8
Output

	*************************
	****************
	*********
	****
	*
	*
	****
	*********
	****************
*/

using System;
public class DisplayGraphicFunction
{
	public static void Main(string[] args)
	{
		int x1 = Convert.ToInt32(Console.ReadLine());
		int x2 = Convert.ToInt32(Console.ReadLine());
		int y;
		for(int x = x1; x <= x2; x++)
		{
			y = (x - 4) * (x - 4);
			for(int j = 0; j < y; j++)
			{

				Console.Write("*");
			}
			
			Console.WriteLine();
		}
	}
}
