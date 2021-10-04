/*
Write a program in C# that asks for a symbol and a width to paint a triangle of that width and height using that number to draw it.

Input

	7
	5
Output

	77777
	7777
	777
	77
	7
*/

using System;
public class DrawTriangle
{
	public static void Main(string[] args)
	{
		int x = Convert.ToInt32(Console.ReadLine());
		int width = Convert.ToInt32(Console.ReadLine());
		int height = width;

		for(int row = 0; row < height; row++)
		{
			for(int column = 0; column < width; column++)
			{
				Console.Write(x);
			}
			Console.WriteLine();
			width--;
		}
	}
}
