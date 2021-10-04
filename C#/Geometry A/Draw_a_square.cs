/*
Write a program in C# that asks for a number (x) and a width to show a square of that width.

Use the number to paint the square.

Input

	1
	5
Output

	11111
	11111
	11111
	11111
	11111
*/

using System;
public class DrawSquare
{
	public static void main(string[] args)
	{
		int x = Convert.ToInt32(Console.ReadLine());
		int width = Convert.ToInt32(Console.ReadKey());
		for(int row = 0; row < width; row++)
		{
			for(int column = 0; column < width; column++)
				Console.Write(x);
			Console.WriteLine();
		}
	}
}
